namespace PhotoBoothRentalSystem.Forms.Client
{
    partial class frmClientProfile
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelProfile = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnChangePic = new System.Windows.Forms.Button();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.chkShowBirthday = new System.Windows.Forms.CheckBox();
            this.lblAgeValue = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnPickLocation = new System.Windows.Forms.Button();
            this.lblBio = new System.Windows.Forms.Label();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.grpAccountInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberSince = new System.Windows.Forms.Label();
            this.lblMemberSinceValue = new System.Windows.Forms.Label();
            this.lblAccountStatus = new System.Windows.Forms.Label();
            this.lblAccountStatusValue = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.grpPersonalInfo.SuspendLayout();
            this.grpAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.Pink;
            this.panelProfile.Controls.Add(this.lblTitle);
            this.panelProfile.Controls.Add(this.picAvatar);
            this.panelProfile.Controls.Add(this.btnChangePic);
            this.panelProfile.Controls.Add(this.grpPersonalInfo);
            this.panelProfile.Controls.Add(this.grpAccountInfo);
            this.panelProfile.Controls.Add(this.btnEdit);
            this.panelProfile.Controls.Add(this.btnSave);
            this.panelProfile.Controls.Add(this.btnCancel);
            this.panelProfile.Controls.Add(this.btnChangePassword);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(743, 745);
            this.panelProfile.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(170, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MY PROFILE";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(20, 10);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(130, 130);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // btnChangePic
            // 
            this.btnChangePic.BackColor = System.Drawing.Color.Black;
            this.btnChangePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePic.FlatAppearance.BorderSize = 0;
            this.btnChangePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePic.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnChangePic.ForeColor = System.Drawing.Color.Plum;
            this.btnChangePic.Location = new System.Drawing.Point(20, 145);
            this.btnChangePic.Name = "btnChangePic";
            this.btnChangePic.Size = new System.Drawing.Size(130, 28);
            this.btnChangePic.TabIndex = 2;
            this.btnChangePic.Text = "Change Photo";
            this.btnChangePic.UseVisualStyleBackColor = false;
            this.btnChangePic.Visible = false;
            this.btnChangePic.Click += new System.EventHandler(this.btnChangePic_Click);
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.BackColor = System.Drawing.Color.LightPink;
            this.grpPersonalInfo.Controls.Add(this.lblFullName);
            this.grpPersonalInfo.Controls.Add(this.txtFullName);
            this.grpPersonalInfo.Controls.Add(this.lblEmail);
            this.grpPersonalInfo.Controls.Add(this.txtEmail);
            this.grpPersonalInfo.Controls.Add(this.lblPhone);
            this.grpPersonalInfo.Controls.Add(this.txtPhone);
            this.grpPersonalInfo.Controls.Add(this.lblGender);
            this.grpPersonalInfo.Controls.Add(this.cboGender);
            this.grpPersonalInfo.Controls.Add(this.lblBirthday);
            this.grpPersonalInfo.Controls.Add(this.dtpBirthday);
            this.grpPersonalInfo.Controls.Add(this.chkShowBirthday);
            this.grpPersonalInfo.Controls.Add(this.lblAgeValue);
            this.grpPersonalInfo.Controls.Add(this.lblLocation);
            this.grpPersonalInfo.Controls.Add(this.txtLocation);
            this.grpPersonalInfo.Controls.Add(this.btnPickLocation);
            this.grpPersonalInfo.Controls.Add(this.lblBio);
            this.grpPersonalInfo.Controls.Add(this.txtBio);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPersonalInfo.Location = new System.Drawing.Point(10, 185);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(720, 400);
            this.grpPersonalInfo.TabIndex = 3;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Information";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFullName.Location = new System.Drawing.Point(16, 30);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(64, 15);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(160, 27);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(250, 25);
            this.txtFullName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.Location = new System.Drawing.Point(16, 66);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(160, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(250, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.Location = new System.Drawing.Point(16, 102);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 15);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(160, 99);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(250, 25);
            this.txtPhone.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGender.Location = new System.Drawing.Point(16, 138);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender:";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Enabled = false;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGender.Location = new System.Drawing.Point(160, 135);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(250, 25);
            this.cboGender.TabIndex = 7;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBirthday.Location = new System.Drawing.Point(16, 174);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(54, 15);
            this.lblBirthday.TabIndex = 8;
            this.lblBirthday.Text = "Birthday:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Enabled = false;
            this.dtpBirthday.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(160, 171);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(160, 25);
            this.dtpBirthday.TabIndex = 9;
            // 
            // chkShowBirthday
            // 
            this.chkShowBirthday.AutoSize = true;
            this.chkShowBirthday.Enabled = false;
            this.chkShowBirthday.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chkShowBirthday.Location = new System.Drawing.Point(328, 174);
            this.chkShowBirthday.Name = "chkShowBirthday";
            this.chkShowBirthday.Size = new System.Drawing.Size(88, 17);
            this.chkShowBirthday.TabIndex = 10;
            this.chkShowBirthday.Text = "Set birthday";
            // 
            // lblAgeValue
            // 
            this.lblAgeValue.AutoSize = true;
            this.lblAgeValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAgeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblAgeValue.Location = new System.Drawing.Point(328, 171);
            this.lblAgeValue.Name = "lblAgeValue";
            this.lblAgeValue.Size = new System.Drawing.Size(0, 15);
            this.lblAgeValue.TabIndex = 11;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocation.Location = new System.Drawing.Point(16, 210);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(56, 15);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(160, 207);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(250, 25);
            this.txtLocation.TabIndex = 13;
            // 
            // btnPickLocation
            // 
            this.btnPickLocation.BackColor = System.Drawing.Color.Black;
            this.btnPickLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickLocation.FlatAppearance.BorderSize = 0;
            this.btnPickLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickLocation.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnPickLocation.ForeColor = System.Drawing.Color.Plum;
            this.btnPickLocation.Location = new System.Drawing.Point(416, 207);
            this.btnPickLocation.Name = "btnPickLocation";
            this.btnPickLocation.Size = new System.Drawing.Size(68, 24);
            this.btnPickLocation.TabIndex = 14;
            this.btnPickLocation.Text = "Map";
            this.btnPickLocation.UseVisualStyleBackColor = false;
            this.btnPickLocation.Visible = false;
            this.btnPickLocation.Click += new System.EventHandler(this.btnPickLocation_Click);
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBio.Location = new System.Drawing.Point(16, 246);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(27, 15);
            this.lblBio.TabIndex = 15;
            this.lblBio.Text = "Bio:";
            // 
            // txtBio
            // 
            this.txtBio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBio.Location = new System.Drawing.Point(160, 243);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.ReadOnly = true;
            this.txtBio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBio.Size = new System.Drawing.Size(250, 70);
            this.txtBio.TabIndex = 16;
            // 
            // grpAccountInfo
            // 
            this.grpAccountInfo.BackColor = System.Drawing.Color.LightPink;
            this.grpAccountInfo.Controls.Add(this.lblMemberSince);
            this.grpAccountInfo.Controls.Add(this.lblMemberSinceValue);
            this.grpAccountInfo.Controls.Add(this.lblAccountStatus);
            this.grpAccountInfo.Controls.Add(this.lblAccountStatusValue);
            this.grpAccountInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpAccountInfo.Location = new System.Drawing.Point(10, 598);
            this.grpAccountInfo.Name = "grpAccountInfo";
            this.grpAccountInfo.Size = new System.Drawing.Size(720, 80);
            this.grpAccountInfo.TabIndex = 4;
            this.grpAccountInfo.TabStop = false;
            this.grpAccountInfo.Text = "Account Info";
            // 
            // lblMemberSince
            // 
            this.lblMemberSince.AutoSize = true;
            this.lblMemberSince.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMemberSince.Location = new System.Drawing.Point(16, 30);
            this.lblMemberSince.Name = "lblMemberSince";
            this.lblMemberSince.Size = new System.Drawing.Size(86, 15);
            this.lblMemberSince.TabIndex = 0;
            this.lblMemberSince.Text = "Member Since:";
            // 
            // lblMemberSinceValue
            // 
            this.lblMemberSinceValue.AutoSize = true;
            this.lblMemberSinceValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMemberSinceValue.Location = new System.Drawing.Point(130, 30);
            this.lblMemberSinceValue.Name = "lblMemberSinceValue";
            this.lblMemberSinceValue.Size = new System.Drawing.Size(12, 15);
            this.lblMemberSinceValue.TabIndex = 1;
            this.lblMemberSinceValue.Text = "-";
            // 
            // lblAccountStatus
            // 
            this.lblAccountStatus.AutoSize = true;
            this.lblAccountStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAccountStatus.Location = new System.Drawing.Point(340, 30);
            this.lblAccountStatus.Name = "lblAccountStatus";
            this.lblAccountStatus.Size = new System.Drawing.Size(42, 15);
            this.lblAccountStatus.TabIndex = 2;
            this.lblAccountStatus.Text = "Status:";
            // 
            // lblAccountStatusValue
            // 
            this.lblAccountStatusValue.AutoSize = true;
            this.lblAccountStatusValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAccountStatusValue.Location = new System.Drawing.Point(400, 30);
            this.lblAccountStatusValue.Name = "lblAccountStatusValue";
            this.lblAccountStatusValue.Size = new System.Drawing.Size(12, 15);
            this.lblAccountStatusValue.TabIndex = 3;
            this.lblAccountStatusValue.Text = "-";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.Plum;
            this.btnEdit.Location = new System.Drawing.Point(10, 692);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "EDIT PROFILE";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 692);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Plum;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(175, 692);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Plum;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Location = new System.Drawing.Point(580, 692);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(150, 36);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // frmClientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(743, 745);
            this.Controls.Add(this.panelProfile);
            this.Name = "frmClientProfile";
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.frmClientProfile_Load);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpAccountInfo.ResumeLayout(false);
            this.grpAccountInfo.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel          panelProfile;
        private System.Windows.Forms.Label          lblTitle;
        private System.Windows.Forms.PictureBox     picAvatar;
        private System.Windows.Forms.Button         btnChangePic;
        private System.Windows.Forms.GroupBox       grpPersonalInfo;
        private System.Windows.Forms.Label          lblFullName;
        private System.Windows.Forms.Label          lblEmail;
        private System.Windows.Forms.Label          lblPhone;
        private System.Windows.Forms.Label          lblGender;
        private System.Windows.Forms.Label          lblBirthday;
        private System.Windows.Forms.Label          lblLocation;
        private System.Windows.Forms.Label          lblBio;
        private System.Windows.Forms.TextBox        txtFullName;
        private System.Windows.Forms.TextBox        txtEmail;
        private System.Windows.Forms.TextBox        txtPhone;
        private System.Windows.Forms.TextBox        txtLocation;
        private System.Windows.Forms.TextBox        txtBio;
        private System.Windows.Forms.ComboBox       cboGender;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.CheckBox       chkShowBirthday;
        private System.Windows.Forms.Label          lblAgeValue;
        private System.Windows.Forms.Button         btnPickLocation;
        private System.Windows.Forms.GroupBox       grpAccountInfo;
        private System.Windows.Forms.Label          lblMemberSince;
        private System.Windows.Forms.Label          lblMemberSinceValue;
        private System.Windows.Forms.Label          lblAccountStatus;
        private System.Windows.Forms.Label          lblAccountStatusValue;
        private System.Windows.Forms.Button         btnEdit;
        private System.Windows.Forms.Button         btnSave;
        private System.Windows.Forms.Button         btnCancel;
        private System.Windows.Forms.Button         btnChangePassword;
    }
}
