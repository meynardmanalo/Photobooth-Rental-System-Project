using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Utilities;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Security;
using PhotoBoothRentalSystem.Forms.Auth;
using PhotoBoothRentalSystem.Forms.Client;
using PhotoBoothRentalSystem.Forms.Shared;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAdminSettings : Form
    {
        private bool   _editMode        = false;
        private bool   _emailOtpVerified= false;
        private string _pendingEmail    = "";
        private string _newPicPath      = "";

        public frmAdminSettings() { InitializeComponent(); }

        private void frmAdminSettings_Load(object sender, EventArgs e)
        {
            cboGender.Items.AddRange(new string[]
                { "", "Male", "Female", "Other", "Prefer not to say" });
            LoadData();
            SetEditMode(false);
        }

        private void LoadData()
        {
            var u = SessionManager.CurrentUser;
            if (u == null) return;

            lblNameValue.Text   = u.FullName;
            lblEmailValue.Text  = u.Email;
            lblPhoneValue.Text  = u.PhoneNumber;
            lblGenderValue.Text = string.IsNullOrWhiteSpace(u.Gender) ? "—" : u.Gender;
            lblLocValue.Text    = string.IsNullOrWhiteSpace(u.Location) ? "—" : u.Location;
            lblBioValue.Text    = string.IsNullOrWhiteSpace(u.Bio) ? "—" : u.Bio;
            lblAgeValue.Text    = u.Age != "—" ? u.Age + " yrs old" : "—";
            lblBdayValue.Text   = u.Birthday.HasValue
                ? u.Birthday.Value.ToString("MMMM dd, yyyy") : "—";

            txtName.Text     = u.FullName;
            txtEmail.Text    = u.Email;
            txtPhone.Text    = u.PhoneNumber;
            txtLocation.Text = u.Location  ?? "";
            txtBio.Text      = u.Bio       ?? "";
            cboGender.Text   = u.Gender    ?? "";
            dtpBirthday.Value = u.Birthday.HasValue ? u.Birthday.Value : new DateTime(2000, 1, 1);
            chkBirthday.Checked = u.Birthday.HasValue;

            LoadProfilePic(u.ProfilePic);
        }

        private void LoadProfilePic(string path)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
                { using (var tmp = new Bitmap(path)) picAvatar.Image = new Bitmap(tmp); }
                else picAvatar.Image = null;
            }
            catch { picAvatar.Image = null; }
        }

        private void SetEditMode(bool on)
        {
            _editMode = on;
            _emailOtpVerified = false;
            _pendingEmail = "";
            _newPicPath = "";

            panelView.Visible = !on;
            panelEdit.Visible =  on;
            btnEdit.Visible   = !on;
            btnSave.Visible   =  on;
            btnCancelEdit.Visible = on;
            btnChangePic.Visible  = on;
        }

        private void btnEdit_Click(object sender, EventArgs e) => SetEditMode(true);
        private void btnCancelEdit_Click(object sender, EventArgs e) { LoadData(); SetEditMode(false); }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Title  = "Select Profile Picture",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _newPicPath = ofd.FileName;
                    try { using (var t = new Bitmap(_newPicPath)) picAvatar.Image = new Bitmap(t); }
                    catch { }
                }
            }
        }

        private void btnPickLocation_Click(object sender, EventArgs e)
        {
            using (var p = new frmLocationPicker(txtLocation.Text))
                if (p.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(p.SelectedAddress))
                    txtLocation.Text = p.SelectedAddress;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name     = (txtName.Text     ?? "").Trim();
            string email    = (txtEmail.Text    ?? "").Trim();
            string phone    = (txtPhone.Text    ?? "").Trim();
            string location = (txtLocation.Text ?? "").Trim();
            string bio      = (txtBio.Text      ?? "").Trim();
            string gender   = cboGender.Text;
            DateTime? bday  = chkBirthday.Checked ? (DateTime?)dtpBirthday.Value.Date : null;

            if (string.IsNullOrWhiteSpace(name))
            { MessageBox.Show("Full name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtName.Focus(); return; }

            if (!InputValidator.IsValidEmail(email))
            { MessageBox.Show("Please enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtEmail.Focus(); return; }

            if (string.IsNullOrWhiteSpace(phone) || phone == "+63") phone = "+639000000000";
            else if (!InputValidator.IsValidPhoneNumber(phone))
            { MessageBox.Show("Invalid phone number.\nFormat: +639123456789", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtPhone.Focus(); return; }

            bool emailChanged = email != SessionManager.CurrentUser.Email;
            if (emailChanged)
            {
                if (!_emailOtpVerified || _pendingEmail != email)
                {
                    if (AuthService.EmailExists(email))
                    { MessageBox.Show("This email is already taken.", "Email Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtEmail.Focus(); return; }
                    SendOtp(email, name, phone, location, bio, gender, bday);
                    return;
                }
            }

            if (phone != "+639000000000" && phone != SessionManager.CurrentUser.PhoneNumber && AuthService.PhoneExists(phone))
            { MessageBox.Show("This phone number is already registered.", "Phone Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtPhone.Focus(); return; }

            DoSave(name, email, phone, location, bio, gender, bday);
        }

        private void SendOtp(string newEmail, string name, string phone,
            string location, string bio, string gender, DateTime? bday)
        {
            var c = MessageBox.Show($"Send verification code to:\n{newEmail}\n\nProceed?",
                "Email Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c != DialogResult.Yes) return;

            btnSave.Enabled = false; btnSave.Text = "Sending...";
            string otp = OTPService.GenerateOTP();
            Task.Run(() => OTPService.SendOTP(newEmail, otp, name))
                .ContinueWith(t =>
                {
                    if (this.IsDisposed) return;
                    this.Invoke((Action)(() =>
                    {
                        btnSave.Enabled = true; btnSave.Text = "SAVE";
                        if (!t.Result) { MessageBox.Show("Failed to send code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        using (Form d = BuildOtpDlg(newEmail))
                        {
                            if (d.ShowDialog() == DialogResult.OK)
                            {
                                string entered = d.Tag?.ToString() ?? "";
                                if (OTPService.VerifyOTP(newEmail, entered))
                                { _emailOtpVerified = true; _pendingEmail = newEmail; DoSave(name, newEmail, phone, location, bio, gender, bday); }
                                else MessageBox.Show("Invalid or expired code.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }));
                }, TaskScheduler.Default);
        }

        private Form BuildOtpDlg(string email)
        {
            var f = new Form { Text = "Verify Email", Size = new Size(380, 200),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog, MaximizeBox = false };
            var lbl = new Label { Text = $"Code sent to:\n{email}", Font = new Font("Segoe UI", 10F), Location = new Point(20, 18), AutoSize = true };
            var txt = new TextBox { Font = new Font("Segoe UI", 14F, FontStyle.Bold), Location = new Point(20, 68), Size = new Size(200, 30), MaxLength = 6, TextAlign = HorizontalAlignment.Center };
            var btn = new Button { Text = "Verify", Location = new Point(240, 68), Size = new Size(100, 30),
                BackColor = Color.FromArgb(231, 76, 60), ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat, DialogResult = DialogResult.OK };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += (s, e) => f.Tag = txt.Text.Trim();
            f.Controls.AddRange(new Control[] { lbl, txt, btn }); f.AcceptButton = btn;
            return f;
        }

        private void DoSave(string name, string email, string phone,
            string location, string bio, string gender, DateTime? bday)
        {
            try
            {
                string picPath = SessionManager.CurrentUser.ProfilePic;
                if (!string.IsNullOrWhiteSpace(_newPicPath))
                {
                    string saved = UserManagementService.SaveProfilePicture(
                        SessionManager.CurrentUser.UserId, _newPicPath);
                    if (!string.IsNullOrWhiteSpace(saved)) picPath = saved;
                }

                if (UserManagementService.UpdateUserProfile(
                    SessionManager.CurrentUser.UserId, name, email, phone,
                    gender, bday, location, bio, picPath))
                {
                    var u = SessionManager.CurrentUser;
                    u.FullName = name; u.Email = email; u.PhoneNumber = phone;
                    u.Gender = gender; u.Birthday = bday; u.Location = location;
                    u.Bio = bio; u.ProfilePic = picPath;

                    MessageBox.Show("Profile updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetEditMode(false);
                    LoadData();
                }
                else MessageBox.Show("Failed to update profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
            => new frmChangePassword().ShowDialog();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SessionManager.Logout();
                new frmAuthSelector().Show();
                this.ParentForm?.Close();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
            => MessageBox.Show("Zass PhotoBooth Rental System\nVersion 1.0\n\nDeveloped by Group 1\n© 2025",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
