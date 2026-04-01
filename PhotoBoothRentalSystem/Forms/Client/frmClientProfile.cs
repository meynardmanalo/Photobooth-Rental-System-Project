using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Utilities;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Security;
using PhotoBoothRentalSystem.Forms.Shared;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmClientProfile : Form
    {
        private bool   _isEditMode       = false;
        private bool   _emailOtpVerified = false;
        private string _pendingEmail     = "";
        private string _newPicPath       = "";

        public frmClientProfile() { InitializeComponent(); }

        private void frmClientProfile_Load(object sender, EventArgs e)
        {
            // Populate gender dropdown
            cboGender.Items.AddRange(new string[]
                { "", "Male", "Female", "Other", "Prefer not to say" });

            LoadProfileData();
            SetEditMode(false);
        }

        // ── Load ─────────────────────────────────────────────
        private void LoadProfileData()
        {
            var u = SessionManager.CurrentUser;
            if (u == null) return;

            txtFullName.Text   = u.FullName;
            txtEmail.Text      = u.Email;
            txtPhone.Text      = u.PhoneNumber;
            txtLocation.Text   = u.Location  ?? "";
            txtBio.Text        = u.Bio       ?? "";
            cboGender.Text     = u.Gender    ?? "";
            dtpBirthday.Value  = u.Birthday.HasValue ? u.Birthday.Value : new DateTime(2000, 1, 1);
            chkShowBirthday.Checked = u.Birthday.HasValue;

            lblMemberSinceValue.Text   = u.CreatedAt.ToString("MMMM dd, yyyy");
            lblAccountStatusValue.Text = u.Status.ToUpper();
            lblAccountStatusValue.ForeColor = u.IsActive()
                ? Color.FromArgb(39, 174, 96) : Color.FromArgb(231, 76, 60);
            lblAgeValue.Text = u.Age != "—" ? u.Age + " yrs old" : "—";

            LoadProfilePicture(u.ProfilePic);
        }

        private void LoadProfilePicture(string picPath)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(picPath) && File.Exists(picPath))
                {
                    using (var tmp = new Bitmap(picPath))
                        picAvatar.Image = new Bitmap(tmp);
                }
                else
                {
                    picAvatar.Image = null;
                }
            }
            catch { picAvatar.Image = null; }
        }

        // ── Edit mode ────────────────────────────────────────
        private void SetEditMode(bool editMode)
        {
            _isEditMode       = editMode;
            _emailOtpVerified = false;
            _pendingEmail     = "";
            _newPicPath       = "";

            txtFullName.ReadOnly = !editMode;
            txtEmail.ReadOnly    = !editMode;
            txtPhone.ReadOnly    = !editMode;
            txtLocation.ReadOnly = !editMode;
            txtBio.ReadOnly      = !editMode;
            cboGender.Enabled    = editMode;
            dtpBirthday.Enabled  = editMode;
            chkShowBirthday.Enabled = editMode;
            btnPickLocation.Visible = editMode;
            btnChangePic.Visible    = editMode;

            btnEdit.Visible   = !editMode;
            btnSave.Visible   = editMode;
            btnCancel.Visible = editMode;

            Color bg = editMode ? Color.White : SystemColors.Control;
            txtFullName.BackColor = bg;
            txtEmail.BackColor    = bg;
            txtPhone.BackColor    = bg;
            txtLocation.BackColor = bg;
            txtBio.BackColor      = bg;
        }

        private void btnEdit_Click(object sender, EventArgs e)   => SetEditMode(true);
        private void btnCancel_Click(object sender, EventArgs e) { LoadProfileData(); SetEditMode(false); }

        // ── Change picture ───────────────────────────────────
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
                    try
                    {
                        using (var tmp = new Bitmap(_newPicPath))
                            picAvatar.Image = new Bitmap(tmp);
                    }
                    catch { }
                }
            }
        }

        // ── Pick location on map ─────────────────────────────
        private void btnPickLocation_Click(object sender, EventArgs e)
        {
            using (var picker = new frmLocationPicker(txtLocation.Text))
            {
                if (picker.ShowDialog() == DialogResult.OK &&
                    !string.IsNullOrWhiteSpace(picker.SelectedAddress))
                    txtLocation.Text = picker.SelectedAddress;
            }
        }

        // ── Save ─────────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = (txtFullName.Text ?? "").Trim();
            string email    = (txtEmail.Text    ?? "").Trim();
            string phone    = (txtPhone.Text    ?? "").Trim();
            string location = (txtLocation.Text ?? "").Trim();
            string bio      = (txtBio.Text      ?? "").Trim();
            string gender   = cboGender.Text;
            DateTime? bday  = chkShowBirthday.Checked ? (DateTime?)dtpBirthday.Value.Date : null;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Full name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus(); return;
            }
            if (!InputValidator.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(phone) || phone == "+63")
                phone = "+639000000000";
            else if (!InputValidator.IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Invalid phone number.\nFormat: +639123456789", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus(); return;
            }

            bool emailChanged = email != SessionManager.CurrentUser.Email;

            if (emailChanged)
            {
                if (!_emailOtpVerified || _pendingEmail != email)
                {
                    if (AuthService.EmailExists(email))
                    {
                        MessageBox.Show("This email is already taken.", "Email Taken",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus(); return;
                    }
                    RequestEmailOtp(email, fullName, phone, location, bio, gender, bday);
                    return;
                }
            }

            if (phone != "+639000000000" &&
                phone != SessionManager.CurrentUser.PhoneNumber &&
                AuthService.PhoneExists(phone))
            {
                MessageBox.Show("This phone number is already registered.", "Phone Taken",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus(); return;
            }

            SaveProfile(fullName, email, phone, location, bio, gender, bday);
        }

        // ── OTP flow ─────────────────────────────────────────
        private void RequestEmailOtp(string newEmail, string fullName, string phone,
            string location, string bio, string gender, DateTime? bday)
        {
            var confirm = MessageBox.Show(
                $"To change your email to:\n{newEmail}\n\nA verification code will be sent there. Proceed?",
                "Email Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            btnSave.Enabled = false;
            btnSave.Text    = "Sending...";
            string otp  = OTPService.GenerateOTP();
            string name = SessionManager.CurrentUser.FullName;

            Task.Run(() => OTPService.SendOTP(newEmail, otp, name))
                .ContinueWith(task =>
                {
                    if (this.IsDisposed) return;
                    this.Invoke((Action)(() =>
                    {
                        btnSave.Enabled = true;
                        btnSave.Text    = "SAVE";
                        if (!task.Result)
                        {
                            MessageBox.Show("Failed to send verification code. Check the email address.",
                                "OTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        using (Form otpDlg = BuildOtpDialog(newEmail))
                        {
                            if (otpDlg.ShowDialog() == DialogResult.OK)
                            {
                                string entered = otpDlg.Tag?.ToString() ?? "";
                                if (OTPService.VerifyOTP(newEmail, entered))
                                {
                                    _emailOtpVerified = true;
                                    _pendingEmail     = newEmail;
                                    MessageBox.Show("Email verified! Saving profile...", "Verified",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    SaveProfile(fullName, newEmail, phone, location, bio, gender, bday);
                                }
                                else
                                    MessageBox.Show("Invalid or expired code.", "Failed",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }));
                }, TaskScheduler.Default);
        }

        private Form BuildOtpDialog(string email)
        {
            var f = new Form
            {
                Text = "Enter Verification Code",
                Size = new Size(380, 200),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };
            var lbl = new Label { Text = $"6-digit code sent to:\n{email}",
                Font = new Font("Segoe UI", 10F), Location = new Point(20, 18), AutoSize = true };
            var txt = new TextBox { Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                Location = new Point(20, 68), Size = new Size(200, 30),
                MaxLength = 6, TextAlign = HorizontalAlignment.Center };
            var btn = new Button { Text = "Verify", Location = new Point(240, 68),
                Size = new Size(100, 30), BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White, FlatStyle = FlatStyle.Flat, DialogResult = DialogResult.OK };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += (s, e) => f.Tag = txt.Text.Trim();
            f.Controls.AddRange(new Control[] { lbl, txt, btn });
            f.AcceptButton = btn;
            return f;
        }

        // ── Actual save ──────────────────────────────────────
        private void SaveProfile(string fullName, string email, string phone,
            string location, string bio, string gender, DateTime? bday)
        {
            try
            {
                // Save profile picture if changed
                string picPath = SessionManager.CurrentUser.ProfilePic;
                if (!string.IsNullOrWhiteSpace(_newPicPath))
                {
                    string saved = UserManagementService.SaveProfilePicture(
                        SessionManager.CurrentUser.UserId, _newPicPath);
                    if (!string.IsNullOrWhiteSpace(saved)) picPath = saved;
                }

                bool ok = UserManagementService.UpdateUserProfile(
                    SessionManager.CurrentUser.UserId,
                    fullName, email, phone, gender, bday, location, bio, picPath);

                if (ok)
                {
                    var u = SessionManager.CurrentUser;
                    u.FullName    = fullName;
                    u.Email       = email;
                    u.PhoneNumber = phone;
                    u.Gender      = gender;
                    u.Birthday    = bday;
                    u.Location    = location;
                    u.Bio         = bio;
                    u.ProfilePic  = picPath;

                    MessageBox.Show("Profile updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetEditMode(false);
                    LoadProfileData();
                }
                else
                    MessageBox.Show("Failed to update profile.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
            => new frmChangePassword().ShowDialog();

        // Empty Designer stubs
    }
}
