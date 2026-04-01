namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAdminSettings
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnChangePic = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblGender2 = new System.Windows.Forms.Label();
            this.lblGenderValue = new System.Windows.Forms.Label();
            this.lblAge2 = new System.Windows.Forms.Label();
            this.lblAgeValue = new System.Windows.Forms.Label();
            this.lblBday2 = new System.Windows.Forms.Label();
            this.lblBdayValue = new System.Windows.Forms.Label();
            this.lblLoc2 = new System.Windows.Forms.Label();
            this.lblLocValue = new System.Windows.Forms.Label();
            this.lblBio2 = new System.Windows.Forms.Label();
            this.lblBioValue = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.lblN = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblG = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblB = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.chkBirthday = new System.Windows.Forms.CheckBox();
            this.lblL = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnPickLocation = new System.Windows.Forms.Button();
            this.lblBi = new System.Windows.Forms.Label();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panelView.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(860, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Account Settings";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(20, 76);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(120, 120);
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
            this.btnChangePic.ForeColor = System.Drawing.Color.White;
            this.btnChangePic.Location = new System.Drawing.Point(20, 200);
            this.btnChangePic.Name = "btnChangePic";
            this.btnChangePic.Size = new System.Drawing.Size(120, 26);
            this.btnChangePic.TabIndex = 2;
            this.btnChangePic.Text = "Change Photo";
            this.btnChangePic.UseVisualStyleBackColor = false;
            this.btnChangePic.Visible = false;
            this.btnChangePic.Click += new System.EventHandler(this.btnChangePic_Click);
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.DarkKhaki;
            this.panelView.Controls.Add(this.lblName);
            this.panelView.Controls.Add(this.lblNameValue);
            this.panelView.Controls.Add(this.lblEmail2);
            this.panelView.Controls.Add(this.lblEmailValue);
            this.panelView.Controls.Add(this.lblPhone2);
            this.panelView.Controls.Add(this.lblPhoneValue);
            this.panelView.Controls.Add(this.lblGender2);
            this.panelView.Controls.Add(this.lblGenderValue);
            this.panelView.Controls.Add(this.lblAge2);
            this.panelView.Controls.Add(this.lblAgeValue);
            this.panelView.Controls.Add(this.lblBday2);
            this.panelView.Controls.Add(this.lblBdayValue);
            this.panelView.Controls.Add(this.lblLoc2);
            this.panelView.Controls.Add(this.lblLocValue);
            this.panelView.Controls.Add(this.lblBio2);
            this.panelView.Controls.Add(this.lblBioValue);
            this.panelView.ForeColor = System.Drawing.Color.Black;
            this.panelView.Location = new System.Drawing.Point(160, 68);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(600, 310);
            this.panelView.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(10, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name:";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblNameValue.Location = new System.Drawing.Point(160, 8);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(15, 19);
            this.lblNameValue.TabIndex = 1;
            this.lblNameValue.Text = "-";
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail2.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail2.Location = new System.Drawing.Point(10, 36);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(39, 15);
            this.lblEmail2.TabIndex = 2;
            this.lblEmail2.Text = "Email:";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEmailValue.Location = new System.Drawing.Point(160, 36);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(15, 19);
            this.lblEmailValue.TabIndex = 3;
            this.lblEmailValue.Text = "-";
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone2.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone2.Location = new System.Drawing.Point(10, 64);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(44, 15);
            this.lblPhone2.TabIndex = 4;
            this.lblPhone2.Text = "Phone:";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblPhoneValue.Location = new System.Drawing.Point(160, 64);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(15, 19);
            this.lblPhoneValue.TabIndex = 5;
            this.lblPhoneValue.Text = "-";
            // 
            // lblGender2
            // 
            this.lblGender2.AutoSize = true;
            this.lblGender2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGender2.ForeColor = System.Drawing.Color.Gray;
            this.lblGender2.Location = new System.Drawing.Point(10, 92);
            this.lblGender2.Name = "lblGender2";
            this.lblGender2.Size = new System.Drawing.Size(48, 15);
            this.lblGender2.TabIndex = 6;
            this.lblGender2.Text = "Gender:";
            // 
            // lblGenderValue
            // 
            this.lblGenderValue.AutoSize = true;
            this.lblGenderValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenderValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblGenderValue.Location = new System.Drawing.Point(160, 92);
            this.lblGenderValue.Name = "lblGenderValue";
            this.lblGenderValue.Size = new System.Drawing.Size(15, 19);
            this.lblGenderValue.TabIndex = 7;
            this.lblGenderValue.Text = "-";
            // 
            // lblAge2
            // 
            this.lblAge2.AutoSize = true;
            this.lblAge2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAge2.ForeColor = System.Drawing.Color.Gray;
            this.lblAge2.Location = new System.Drawing.Point(10, 120);
            this.lblAge2.Name = "lblAge2";
            this.lblAge2.Size = new System.Drawing.Size(31, 15);
            this.lblAge2.TabIndex = 8;
            this.lblAge2.Text = "Age:";
            // 
            // lblAgeValue
            // 
            this.lblAgeValue.AutoSize = true;
            this.lblAgeValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAgeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblAgeValue.Location = new System.Drawing.Point(160, 120);
            this.lblAgeValue.Name = "lblAgeValue";
            this.lblAgeValue.Size = new System.Drawing.Size(15, 19);
            this.lblAgeValue.TabIndex = 9;
            this.lblAgeValue.Text = "-";
            // 
            // lblBday2
            // 
            this.lblBday2.AutoSize = true;
            this.lblBday2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBday2.ForeColor = System.Drawing.Color.Gray;
            this.lblBday2.Location = new System.Drawing.Point(10, 148);
            this.lblBday2.Name = "lblBday2";
            this.lblBday2.Size = new System.Drawing.Size(54, 15);
            this.lblBday2.TabIndex = 10;
            this.lblBday2.Text = "Birthday:";
            // 
            // lblBdayValue
            // 
            this.lblBdayValue.AutoSize = true;
            this.lblBdayValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBdayValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBdayValue.Location = new System.Drawing.Point(160, 148);
            this.lblBdayValue.Name = "lblBdayValue";
            this.lblBdayValue.Size = new System.Drawing.Size(15, 19);
            this.lblBdayValue.TabIndex = 11;
            this.lblBdayValue.Text = "-";
            // 
            // lblLoc2
            // 
            this.lblLoc2.AutoSize = true;
            this.lblLoc2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoc2.ForeColor = System.Drawing.Color.Gray;
            this.lblLoc2.Location = new System.Drawing.Point(10, 176);
            this.lblLoc2.Name = "lblLoc2";
            this.lblLoc2.Size = new System.Drawing.Size(56, 15);
            this.lblLoc2.TabIndex = 12;
            this.lblLoc2.Text = "Location:";
            // 
            // lblLocValue
            // 
            this.lblLocValue.AutoSize = true;
            this.lblLocValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblLocValue.Location = new System.Drawing.Point(160, 176);
            this.lblLocValue.Name = "lblLocValue";
            this.lblLocValue.Size = new System.Drawing.Size(15, 19);
            this.lblLocValue.TabIndex = 13;
            this.lblLocValue.Text = "-";
            // 
            // lblBio2
            // 
            this.lblBio2.AutoSize = true;
            this.lblBio2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBio2.ForeColor = System.Drawing.Color.Gray;
            this.lblBio2.Location = new System.Drawing.Point(10, 204);
            this.lblBio2.Name = "lblBio2";
            this.lblBio2.Size = new System.Drawing.Size(27, 15);
            this.lblBio2.TabIndex = 14;
            this.lblBio2.Text = "Bio:";
            // 
            // lblBioValue
            // 
            this.lblBioValue.AutoSize = true;
            this.lblBioValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBioValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBioValue.Location = new System.Drawing.Point(160, 204);
            this.lblBioValue.Name = "lblBioValue";
            this.lblBioValue.Size = new System.Drawing.Size(15, 19);
            this.lblBioValue.TabIndex = 15;
            this.lblBioValue.Text = "-";
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.Transparent;
            this.panelEdit.Controls.Add(this.lblN);
            this.panelEdit.Controls.Add(this.txtName);
            this.panelEdit.Controls.Add(this.lblE);
            this.panelEdit.Controls.Add(this.txtEmail);
            this.panelEdit.Controls.Add(this.lblP);
            this.panelEdit.Controls.Add(this.txtPhone);
            this.panelEdit.Controls.Add(this.lblG);
            this.panelEdit.Controls.Add(this.cboGender);
            this.panelEdit.Controls.Add(this.lblB);
            this.panelEdit.Controls.Add(this.dtpBirthday);
            this.panelEdit.Controls.Add(this.chkBirthday);
            this.panelEdit.Controls.Add(this.lblL);
            this.panelEdit.Controls.Add(this.txtLocation);
            this.panelEdit.Controls.Add(this.btnPickLocation);
            this.panelEdit.Controls.Add(this.lblBi);
            this.panelEdit.Controls.Add(this.txtBio);
            this.panelEdit.Location = new System.Drawing.Point(160, 68);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(600, 310);
            this.panelEdit.TabIndex = 4;
            this.panelEdit.Visible = false;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblN.Location = new System.Drawing.Point(10, 8);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(64, 15);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Full Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(140, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 25);
            this.txtName.TabIndex = 1;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblE.Location = new System.Drawing.Point(10, 42);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(39, 15);
            this.lblE.TabIndex = 2;
            this.lblE.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(140, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblP.Location = new System.Drawing.Point(10, 76);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(44, 15);
            this.lblP.TabIndex = 4;
            this.lblP.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(140, 72);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 25);
            this.txtPhone.TabIndex = 5;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblG.Location = new System.Drawing.Point(10, 110);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(48, 15);
            this.lblG.TabIndex = 6;
            this.lblG.Text = "Gender:";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGender.Location = new System.Drawing.Point(140, 106);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(240, 25);
            this.cboGender.TabIndex = 7;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblB.Location = new System.Drawing.Point(10, 144);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(54, 15);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "Birthday:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(140, 140);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(160, 25);
            this.dtpBirthday.TabIndex = 9;
            // 
            // chkBirthday
            // 
            this.chkBirthday.AutoSize = true;
            this.chkBirthday.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chkBirthday.Location = new System.Drawing.Point(306, 144);
            this.chkBirthday.Name = "chkBirthday";
            this.chkBirthday.Size = new System.Drawing.Size(42, 17);
            this.chkBirthday.TabIndex = 10;
            this.chkBirthday.Text = "Set";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblL.Location = new System.Drawing.Point(10, 178);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(56, 15);
            this.lblL.TabIndex = 11;
            this.lblL.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(140, 174);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(240, 25);
            this.txtLocation.TabIndex = 12;
            // 
            // btnPickLocation
            // 
            this.btnPickLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnPickLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickLocation.FlatAppearance.BorderSize = 0;
            this.btnPickLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickLocation.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnPickLocation.ForeColor = System.Drawing.Color.White;
            this.btnPickLocation.Location = new System.Drawing.Point(386, 174);
            this.btnPickLocation.Name = "btnPickLocation";
            this.btnPickLocation.Size = new System.Drawing.Size(64, 26);
            this.btnPickLocation.TabIndex = 13;
            this.btnPickLocation.Text = "Map";
            this.btnPickLocation.UseVisualStyleBackColor = false;
            this.btnPickLocation.Click += new System.EventHandler(this.btnPickLocation_Click);
            // 
            // lblBi
            // 
            this.lblBi.AutoSize = true;
            this.lblBi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBi.Location = new System.Drawing.Point(10, 212);
            this.lblBi.Name = "lblBi";
            this.lblBi.Size = new System.Drawing.Size(27, 15);
            this.lblBi.TabIndex = 14;
            this.lblBi.Text = "Bio:";
            // 
            // txtBio
            // 
            this.txtBio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBio.Location = new System.Drawing.Point(140, 208);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBio.Size = new System.Drawing.Size(240, 52);
            this.txtBio.TabIndex = 15;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(20, 400);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.White;
            this.btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelEdit.ForeColor = System.Drawing.Color.Black;
            this.btnCancelEdit.Location = new System.Drawing.Point(170, 400);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(140, 36);
            this.btnCancelEdit.TabIndex = 7;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Black;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(20, 446);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(140, 36);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(540, 400);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 36);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Location = new System.Drawing.Point(690, 400);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(140, 36);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmAdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(860, 500);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btnChangePic);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAbout);
            this.Name = "frmAdminSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmAdminSettings_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel          panelHeader;
        private System.Windows.Forms.Label          lblTitle;
        private System.Windows.Forms.PictureBox     picAvatar;
        private System.Windows.Forms.Button         btnChangePic;
        private System.Windows.Forms.Panel          panelView;
        private System.Windows.Forms.Label          lblName, lblNameValue;
        private System.Windows.Forms.Label          lblEmail2, lblEmailValue;
        private System.Windows.Forms.Label          lblPhone2, lblPhoneValue;
        private System.Windows.Forms.Label          lblGender2, lblGenderValue;
        private System.Windows.Forms.Label          lblAge2, lblAgeValue;
        private System.Windows.Forms.Label          lblBday2, lblBdayValue;
        private System.Windows.Forms.Label          lblLoc2, lblLocValue;
        private System.Windows.Forms.Label          lblBio2, lblBioValue;
        private System.Windows.Forms.Panel          panelEdit;
        private System.Windows.Forms.Label          lblN, lblE, lblP, lblG, lblB, lblL, lblBi;
        private System.Windows.Forms.TextBox        txtName, txtEmail, txtPhone, txtLocation, txtBio;
        private System.Windows.Forms.ComboBox       cboGender;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.CheckBox       chkBirthday;
        private System.Windows.Forms.Button         btnPickLocation;
        private System.Windows.Forms.Button         btnEdit, btnSave, btnCancelEdit;
        private System.Windows.Forms.Button         btnChangePassword, btnLogout, btnAbout;
    }
}
