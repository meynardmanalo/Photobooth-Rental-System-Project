namespace PhotoBoothRentalSystem.Forms.Client
{
    partial class frmCreateOrder
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picPackageIcon = new System.Windows.Forms.PictureBox();
            this.panelPackageCard = new System.Windows.Forms.Panel();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.lblPackageType = new System.Windows.Forms.Label();
            this.lblPackagePrice = new System.Windows.Forms.Label();
            this.lblPackageHours = new System.Windows.Forms.Label();
            this.lblPackagePhotos = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.grpEvent = new System.Windows.Forms.GroupBox();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnPickLocation = new System.Windows.Forms.Button();
            this.lblEventType = new System.Windows.Forms.Label();
            this.cboEventType = new System.Windows.Forms.ComboBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.grpPeople = new System.Windows.Forms.GroupBox();
            this.lblCelebrant = new System.Windows.Forms.Label();
            this.txtCelebrantName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.lblCelebrantPhoto = new System.Windows.Forms.Label();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.lblPhotoPath = new System.Windows.Forms.Label();
            this.lblInvitation = new System.Windows.Forms.Label();
            this.btnUploadInvitation = new System.Windows.Forms.Button();
            this.lblInvitationPath = new System.Windows.Forms.Label();
            this.grpSpecial = new System.Windows.Forms.GroupBox();
            this.txtSpecialRequests = new System.Windows.Forms.TextBox();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblDownLabel = new System.Windows.Forms.Label();
            this.lblDownValue = new System.Windows.Forms.Label();
            this.lblBalanceLabel = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.chkAgreeTerms = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPackageIcon)).BeginInit();
            this.panelPackageCard.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.grpEvent.SuspendLayout();
            this.grpPeople.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.grpFiles.SuspendLayout();
            this.grpSpecial.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Thistle;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(880, 56);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book a PhotoBooth";
            // 
            // picPackageIcon
            // 
            this.picPackageIcon.Location = new System.Drawing.Point(0, 0);
            this.picPackageIcon.Name = "picPackageIcon";
            this.picPackageIcon.Size = new System.Drawing.Size(100, 50);
            this.picPackageIcon.TabIndex = 0;
            this.picPackageIcon.TabStop = false;
            // 
            // panelPackageCard
            // 
            this.panelPackageCard.BackColor = System.Drawing.Color.Thistle;
            this.panelPackageCard.Controls.Add(this.lblPackageName);
            this.panelPackageCard.Controls.Add(this.lblPackageType);
            this.panelPackageCard.Controls.Add(this.lblPackagePrice);
            this.panelPackageCard.Controls.Add(this.lblPackageHours);
            this.panelPackageCard.Controls.Add(this.lblPackagePhotos);
            this.panelPackageCard.Location = new System.Drawing.Point(10, 64);
            this.panelPackageCard.Name = "panelPackageCard";
            this.panelPackageCard.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.panelPackageCard.Size = new System.Drawing.Size(860, 70);
            this.panelPackageCard.TabIndex = 1;
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPackageName.ForeColor = System.Drawing.Color.Purple;
            this.lblPackageName.Location = new System.Drawing.Point(14, 10);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(83, 25);
            this.lblPackageName.TabIndex = 0;
            this.lblPackageName.Text = "Package";
            // 
            // lblPackageType
            // 
            this.lblPackageType.AutoSize = true;
            this.lblPackageType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPackageType.ForeColor = System.Drawing.Color.Black;
            this.lblPackageType.Location = new System.Drawing.Point(14, 36);
            this.lblPackageType.Name = "lblPackageType";
            this.lblPackageType.Size = new System.Drawing.Size(31, 15);
            this.lblPackageType.TabIndex = 1;
            this.lblPackageType.Text = "Type";
            // 
            // lblPackagePrice
            // 
            this.lblPackagePrice.AutoSize = true;
            this.lblPackagePrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPackagePrice.ForeColor = System.Drawing.Color.Black;
            this.lblPackagePrice.Location = new System.Drawing.Point(620, 10);
            this.lblPackagePrice.Name = "lblPackagePrice";
            this.lblPackagePrice.Size = new System.Drawing.Size(72, 30);
            this.lblPackagePrice.TabIndex = 2;
            this.lblPackagePrice.Text = "P0.00";
            // 
            // lblPackageHours
            // 
            this.lblPackageHours.AutoSize = true;
            this.lblPackageHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPackageHours.ForeColor = System.Drawing.Color.Black;
            this.lblPackageHours.Location = new System.Drawing.Point(620, 38);
            this.lblPackageHours.Name = "lblPackageHours";
            this.lblPackageHours.Size = new System.Drawing.Size(32, 15);
            this.lblPackageHours.TabIndex = 3;
            this.lblPackageHours.Text = "0 hrs";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Black;
            this.panelLeft.Controls.Add(this.grpEvent);
            this.panelLeft.Controls.Add(this.grpPeople);
            this.panelLeft.Location = new System.Drawing.Point(10, 142);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(430, 520);
            this.panelLeft.TabIndex = 2;
            // 
            // grpEvent
            // 
            this.grpEvent.BackColor = System.Drawing.Color.LightPink;
            this.grpEvent.Controls.Add(this.lblEventDate);
            this.grpEvent.Controls.Add(this.dtpEventDate);
            this.grpEvent.Controls.Add(this.lblLocation);
            this.grpEvent.Controls.Add(this.txtLocation);
            this.grpEvent.Controls.Add(this.btnPickLocation);
            this.grpEvent.Controls.Add(this.lblEventType);
            this.grpEvent.Controls.Add(this.cboEventType);
            this.grpEvent.Controls.Add(this.lblTheme);
            this.grpEvent.Controls.Add(this.txtTheme);
            this.grpEvent.Controls.Add(this.lblStartTime);
            this.grpEvent.Controls.Add(this.timeStart);
            this.grpEvent.Controls.Add(this.lblEndTime);
            this.grpEvent.Controls.Add(this.timeEnd);
            this.grpEvent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpEvent.Location = new System.Drawing.Point(0, 0);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Size = new System.Drawing.Size(430, 300);
            this.grpEvent.TabIndex = 0;
            this.grpEvent.TabStop = false;
            this.grpEvent.Text = "Event Details";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEventDate.Location = new System.Drawing.Point(14, 28);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(71, 15);
            this.lblEventDate.TabIndex = 0;
            this.lblEventDate.Text = "Event Date *";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEventDate.Location = new System.Drawing.Point(160, 24);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(250, 25);
            this.dtpEventDate.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocation.Location = new System.Drawing.Point(14, 62);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(61, 15);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location *";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(160, 58);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(184, 25);
            this.txtLocation.TabIndex = 3;
            // 
            // btnPickLocation
            // 
            this.btnPickLocation.BackColor = System.Drawing.Color.Black;
            this.btnPickLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickLocation.FlatAppearance.BorderSize = 0;
            this.btnPickLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickLocation.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnPickLocation.ForeColor = System.Drawing.Color.Plum;
            this.btnPickLocation.Location = new System.Drawing.Point(350, 58);
            this.btnPickLocation.Name = "btnPickLocation";
            this.btnPickLocation.Size = new System.Drawing.Size(60, 26);
            this.btnPickLocation.TabIndex = 4;
            this.btnPickLocation.Text = "Map";
            this.btnPickLocation.UseVisualStyleBackColor = false;
            this.btnPickLocation.Click += new System.EventHandler(this.btnPickLocation_Click);
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEventType.Location = new System.Drawing.Point(14, 96);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(71, 15);
            this.lblEventType.TabIndex = 5;
            this.lblEventType.Text = "Event Type *";
            // 
            // cboEventType
            // 
            this.cboEventType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEventType.Location = new System.Drawing.Point(160, 92);
            this.cboEventType.Name = "cboEventType";
            this.cboEventType.Size = new System.Drawing.Size(250, 25);
            this.cboEventType.TabIndex = 6;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTheme.Location = new System.Drawing.Point(14, 130);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(43, 15);
            this.lblTheme.TabIndex = 7;
            this.lblTheme.Text = "Theme";
            // 
            // txtTheme
            // 
            this.txtTheme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTheme.Location = new System.Drawing.Point(160, 126);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(250, 25);
            this.txtTheme.TabIndex = 8;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStartTime.Location = new System.Drawing.Point(14, 164);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(68, 15);
            this.lblStartTime.TabIndex = 9;
            this.lblStartTime.Text = "Start Time *";
            // 
            // timeStart
            // 
            this.timeStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(160, 160);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(250, 25);
            this.timeStart.TabIndex = 10;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEndTime.Location = new System.Drawing.Point(14, 198);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(64, 15);
            this.lblEndTime.TabIndex = 11;
            this.lblEndTime.Text = "End Time *";
            // 
            // timeEnd
            // 
            this.timeEnd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(160, 194);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(250, 25);
            this.timeEnd.TabIndex = 12;
            // 
            // grpPeople
            // 
            this.grpPeople.BackColor = System.Drawing.Color.LightPink;
            this.grpPeople.Controls.Add(this.lblCelebrant);
            this.grpPeople.Controls.Add(this.txtCelebrantName);
            this.grpPeople.Controls.Add(this.lblContact);
            this.grpPeople.Controls.Add(this.txtContactPerson);
            this.grpPeople.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPeople.Location = new System.Drawing.Point(0, 308);
            this.grpPeople.Name = "grpPeople";
            this.grpPeople.Size = new System.Drawing.Size(430, 190);
            this.grpPeople.TabIndex = 1;
            this.grpPeople.TabStop = false;
            this.grpPeople.Text = "People & Setup";
            // 
            // lblCelebrant
            // 
            this.lblCelebrant.AutoSize = true;
            this.lblCelebrant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCelebrant.Location = new System.Drawing.Point(14, 28);
            this.lblCelebrant.Name = "lblCelebrant";
            this.lblCelebrant.Size = new System.Drawing.Size(58, 15);
            this.lblCelebrant.TabIndex = 0;
            this.lblCelebrant.Text = "Celebrant";
            // 
            // txtCelebrantName
            // 
            this.txtCelebrantName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCelebrantName.Location = new System.Drawing.Point(160, 24);
            this.txtCelebrantName.Name = "txtCelebrantName";
            this.txtCelebrantName.Size = new System.Drawing.Size(250, 25);
            this.txtCelebrantName.TabIndex = 1;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContact.Location = new System.Drawing.Point(14, 62);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(57, 15);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact *";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContactPerson.Location = new System.Drawing.Point(160, 58);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(250, 25);
            this.txtContactPerson.TabIndex = 3;
            // 
            // 
            // 
            // 
            1000,
            0,
            0,
            0});
            1,
            0,
            0,
            0});
            50,
            0,
            0,
            0});
            // 
            // 
            // 
            // 
            1,
            0,
            0,
            0});
            10,
            0,
            0,
            0});
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Black;
            this.panelRight.Controls.Add(this.grpFiles);
            this.panelRight.Controls.Add(this.grpSpecial);
            this.panelRight.Controls.Add(this.grpPayment);
            this.panelRight.Controls.Add(this.chkAgreeTerms);
            this.panelRight.Controls.Add(this.btnSubmit);
            this.panelRight.Controls.Add(this.btnCancel);
            this.panelRight.ForeColor = System.Drawing.Color.Plum;
            this.panelRight.Location = new System.Drawing.Point(450, 142);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(420, 520);
            this.panelRight.TabIndex = 3;
            // 
            // grpFiles
            // 
            this.grpFiles.BackColor = System.Drawing.Color.LightPink;
            this.grpFiles.Controls.Add(this.lblCelebrantPhoto);
            this.grpFiles.Controls.Add(this.btnUploadPhoto);
            this.grpFiles.Controls.Add(this.lblPhotoPath);
            this.grpFiles.Controls.Add(this.lblInvitation);
            this.grpFiles.Controls.Add(this.btnUploadInvitation);
            this.grpFiles.Controls.Add(this.lblInvitationPath);
            this.grpFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFiles.Location = new System.Drawing.Point(0, 0);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(420, 160);
            this.grpFiles.TabIndex = 0;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Documents (Optional)";
            // 
            // lblCelebrantPhoto
            // 
            this.lblCelebrantPhoto.AutoSize = true;
            this.lblCelebrantPhoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCelebrantPhoto.Location = new System.Drawing.Point(14, 28);
            this.lblCelebrantPhoto.Name = "lblCelebrantPhoto";
            this.lblCelebrantPhoto.Size = new System.Drawing.Size(96, 15);
            this.lblCelebrantPhoto.TabIndex = 0;
            this.lblCelebrantPhoto.Text = "Celebrant Photo:";
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.Color.Black;
            this.btnUploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadPhoto.ForeColor = System.Drawing.Color.Plum;
            this.btnUploadPhoto.Location = new System.Drawing.Point(180, 24);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(110, 28);
            this.btnUploadPhoto.TabIndex = 1;
            this.btnUploadPhoto.Text = "Upload Photo";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // lblPhotoPath
            // 
            this.lblPhotoPath.AutoSize = true;
            this.lblPhotoPath.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPhotoPath.ForeColor = System.Drawing.Color.Gray;
            this.lblPhotoPath.Location = new System.Drawing.Point(180, 54);
            this.lblPhotoPath.Name = "lblPhotoPath";
            this.lblPhotoPath.Size = new System.Drawing.Size(86, 13);
            this.lblPhotoPath.TabIndex = 2;
            this.lblPhotoPath.Text = "No file selected";
            // 
            // lblInvitation
            // 
            this.lblInvitation.AutoSize = true;
            this.lblInvitation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInvitation.Location = new System.Drawing.Point(14, 90);
            this.lblInvitation.Name = "lblInvitation";
            this.lblInvitation.Size = new System.Drawing.Size(88, 15);
            this.lblInvitation.TabIndex = 3;
            this.lblInvitation.Text = "Invitation Card:";
            // 
            // btnUploadInvitation
            // 
            this.btnUploadInvitation.BackColor = System.Drawing.Color.Black;
            this.btnUploadInvitation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadInvitation.FlatAppearance.BorderSize = 0;
            this.btnUploadInvitation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadInvitation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadInvitation.ForeColor = System.Drawing.Color.Plum;
            this.btnUploadInvitation.Location = new System.Drawing.Point(180, 86);
            this.btnUploadInvitation.Name = "btnUploadInvitation";
            this.btnUploadInvitation.Size = new System.Drawing.Size(110, 28);
            this.btnUploadInvitation.TabIndex = 4;
            this.btnUploadInvitation.Text = "Upload Card";
            this.btnUploadInvitation.UseVisualStyleBackColor = false;
            this.btnUploadInvitation.Click += new System.EventHandler(this.btnUploadInvitation_Click);
            // 
            // lblInvitationPath
            // 
            this.lblInvitationPath.AutoSize = true;
            this.lblInvitationPath.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInvitationPath.ForeColor = System.Drawing.Color.Gray;
            this.lblInvitationPath.Location = new System.Drawing.Point(180, 116);
            this.lblInvitationPath.Name = "lblInvitationPath";
            this.lblInvitationPath.Size = new System.Drawing.Size(86, 13);
            this.lblInvitationPath.TabIndex = 5;
            this.lblInvitationPath.Text = "No file selected";
            // 
            // grpSpecial
            // 
            this.grpSpecial.BackColor = System.Drawing.Color.LightPink;
            this.grpSpecial.Controls.Add(this.txtSpecialRequests);
            this.grpSpecial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpSpecial.Location = new System.Drawing.Point(0, 168);
            this.grpSpecial.Name = "grpSpecial";
            this.grpSpecial.Size = new System.Drawing.Size(420, 120);
            this.grpSpecial.TabIndex = 1;
            this.grpSpecial.TabStop = false;
            this.grpSpecial.Text = "Special Requests / Notes";
            // 
            // txtSpecialRequests
            // 
            this.txtSpecialRequests.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpecialRequests.Location = new System.Drawing.Point(14, 22);
            this.txtSpecialRequests.MaxLength = 500;
            this.txtSpecialRequests.Multiline = true;
            this.txtSpecialRequests.Name = "txtSpecialRequests";
            this.txtSpecialRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpecialRequests.Size = new System.Drawing.Size(390, 86);
            this.txtSpecialRequests.TabIndex = 0;
            // 
            // grpPayment
            // 
            this.grpPayment.BackColor = System.Drawing.Color.LightPink;
            this.grpPayment.Controls.Add(this.lblTotalLabel);
            this.grpPayment.Controls.Add(this.lblTotalValue);
            this.grpPayment.Controls.Add(this.lblDownLabel);
            this.grpPayment.Controls.Add(this.lblDownValue);
            this.grpPayment.Controls.Add(this.lblBalanceLabel);
            this.grpPayment.Controls.Add(this.lblBalanceValue);
            this.grpPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPayment.Location = new System.Drawing.Point(0, 296);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(420, 120);
            this.grpPayment.TabIndex = 2;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Summary";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalLabel.Location = new System.Drawing.Point(14, 28);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(82, 15);
            this.lblTotalLabel.TabIndex = 0;
            this.lblTotalLabel.Text = "Package Total:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalValue.Location = new System.Drawing.Point(250, 26);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(15, 20);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "-";
            // 
            // lblDownLabel
            // 
            this.lblDownLabel.AutoSize = true;
            this.lblDownLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDownLabel.Location = new System.Drawing.Point(14, 56);
            this.lblDownLabel.Name = "lblDownLabel";
            this.lblDownLabel.Size = new System.Drawing.Size(91, 15);
            this.lblDownLabel.TabIndex = 2;
            this.lblDownLabel.Text = "Down Payment:";
            // 
            // lblDownValue
            // 
            this.lblDownValue.AutoSize = true;
            this.lblDownValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDownValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblDownValue.Location = new System.Drawing.Point(250, 54);
            this.lblDownValue.Name = "lblDownValue";
            this.lblDownValue.Size = new System.Drawing.Size(15, 20);
            this.lblDownValue.TabIndex = 3;
            this.lblDownValue.Text = "-";
            // 
            // lblBalanceLabel
            // 
            this.lblBalanceLabel.AutoSize = true;
            this.lblBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBalanceLabel.Location = new System.Drawing.Point(14, 84);
            this.lblBalanceLabel.Name = "lblBalanceLabel";
            this.lblBalanceLabel.Size = new System.Drawing.Size(100, 15);
            this.lblBalanceLabel.TabIndex = 4;
            this.lblBalanceLabel.Text = "Balance on Event:";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBalanceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblBalanceValue.Location = new System.Drawing.Point(250, 82);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(15, 20);
            this.lblBalanceValue.TabIndex = 5;
            this.lblBalanceValue.Text = "-";
            // 
            // chkAgreeTerms
            // 
            this.chkAgreeTerms.AutoSize = true;
            this.chkAgreeTerms.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chkAgreeTerms.Location = new System.Drawing.Point(17, 427);
            this.chkAgreeTerms.Name = "chkAgreeTerms";
            this.chkAgreeTerms.Size = new System.Drawing.Size(207, 17);
            this.chkAgreeTerms.TabIndex = 3;
            this.chkAgreeTerms.Text = "I agree to the terms and conditions";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Plum;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(12, 454);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 44);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancel.Location = new System.Drawing.Point(218, 454);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 44);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(880, 680);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelPackageCard);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Book PhotoBooth";
            this.Load += new System.EventHandler(this.frmCreateOrder_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPackageIcon)).EndInit();
            this.panelPackageCard.ResumeLayout(false);
            this.panelPackageCard.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.grpEvent.ResumeLayout(false);
            this.grpEvent.PerformLayout();
            this.grpPeople.ResumeLayout(false);
            this.grpPeople.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.grpFiles.ResumeLayout(false);
            this.grpFiles.PerformLayout();
            this.grpSpecial.ResumeLayout(false);
            this.grpSpecial.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel       panelHeader, panelPackageCard, panelLeft, panelRight;
        private System.Windows.Forms.Label       lblTitle, lblPackageName, lblPackageType, lblPackagePrice, lblPackageHours, lblPackagePhotos;
        private System.Windows.Forms.PictureBox  picPackageIcon;
        private System.Windows.Forms.GroupBox    grpEvent, grpPeople, grpFiles, grpSpecial, grpPayment;
        private System.Windows.Forms.Label       lblEventDate, lblLocation, lblEventType, lblTheme, lblStartTime, lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEventDate, timeStart, timeEnd;
        private System.Windows.Forms.TextBox     txtLocation, txtTheme;
        private System.Windows.Forms.Button      btnPickLocation;
        private System.Windows.Forms.ComboBox    cboEventType;
        private System.Windows.Forms.TextBox     txtCelebrantName, txtContactPerson;
        private System.Windows.Forms.Label       lblCelebrantPhoto, lblPhotoPath, lblInvitation, lblInvitationPath;
        private System.Windows.Forms.Button      btnUploadPhoto, btnUploadInvitation;
        private System.Windows.Forms.TextBox     txtSpecialRequests;
        private System.Windows.Forms.Label       lblTotalLabel, lblTotalValue, lblDownLabel, lblDownValue, lblBalanceLabel, lblBalanceValue;
        private System.Windows.Forms.CheckBox    chkAgreeTerms;
        private System.Windows.Forms.Button      btnSubmit, btnCancel;
    }
}
