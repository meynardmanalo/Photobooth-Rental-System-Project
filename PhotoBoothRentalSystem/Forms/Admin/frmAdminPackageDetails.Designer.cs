namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAdminPackageDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.lblHeaderStatus = new System.Windows.Forms.Label();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMedia = new System.Windows.Forms.TabPage();
            this.flowMedia = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMediaActions = new System.Windows.Forms.Panel();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnAddSticker = new System.Windows.Forms.Button();
            this.btnDeleteMedia = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.tabRatings = new System.Windows.Forms.TabPage();
            this.dgvRatings = new System.Windows.Forms.DataGridView();
            this.colRatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRatCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRatStars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRatFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRatReply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRatDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRatingActions = new System.Windows.Forms.Panel();
            this.btnReplyRating = new System.Windows.Forms.Button();
            this.btnHideRating = new System.Windows.Forms.Button();
            this.lblRatingSummary = new System.Windows.Forms.Label();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colOrdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrdLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrdStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMedia.SuspendLayout();
            this.panelMediaActions.SuspendLayout();
            this.tabRatings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).BeginInit();
            this.panelRatingActions.SuspendLayout();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.lblHeaderName);
            this.panelHeader.Controls.Add(this.lblHeaderSub);
            this.panelHeader.Controls.Add(this.lblHeaderStatus);
            this.panelHeader.Controls.Add(this.btnEditPackage);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.panelHeader.Size = new System.Drawing.Size(1000, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderName.ForeColor = System.Drawing.Color.White;
            this.lblHeaderName.Location = new System.Drawing.Point(16, 8);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(0, 30);
            this.lblHeaderName.TabIndex = 0;
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(18, 42);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(0, 19);
            this.lblHeaderSub.TabIndex = 1;
            // 
            // lblHeaderStatus
            // 
            this.lblHeaderStatus.AutoSize = true;
            this.lblHeaderStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblHeaderStatus.Location = new System.Drawing.Point(18, 58);
            this.lblHeaderStatus.Name = "lblHeaderStatus";
            this.lblHeaderStatus.Size = new System.Drawing.Size(0, 19);
            this.lblHeaderStatus.TabIndex = 2;
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPackage.FlatAppearance.BorderSize = 0;
            this.btnEditPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPackage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditPackage.ForeColor = System.Drawing.Color.White;
            this.btnEditPackage.Location = new System.Drawing.Point(1630, 22);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(150, 36);
            this.btnEditPackage.TabIndex = 3;
            this.btnEditPackage.Text = "Edit Package Info";
            this.btnEditPackage.UseVisualStyleBackColor = false;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMedia);
            this.tabControl.Controls.Add(this.tabRatings);
            this.tabControl.Controls.Add(this.tabOrders);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabControl.Location = new System.Drawing.Point(0, 80);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 530);
            this.tabControl.TabIndex = 0;
            // 
            // tabMedia
            // 
            this.tabMedia.BackColor = System.Drawing.Color.White;
            this.tabMedia.Controls.Add(this.flowMedia);
            this.tabMedia.Controls.Add(this.panelMediaActions);
            this.tabMedia.Location = new System.Drawing.Point(4, 29);
            this.tabMedia.Name = "tabMedia";
            this.tabMedia.Size = new System.Drawing.Size(992, 497);
            this.tabMedia.TabIndex = 0;
            this.tabMedia.Text = "  Media  ";
            // 
            // flowMedia
            // 
            this.flowMedia.AutoScroll = true;
            this.flowMedia.BackColor = System.Drawing.Color.Wheat;
            this.flowMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMedia.Location = new System.Drawing.Point(0, 0);
            this.flowMedia.Name = "flowMedia";
            this.flowMedia.Padding = new System.Windows.Forms.Padding(10);
            this.flowMedia.Size = new System.Drawing.Size(992, 441);
            this.flowMedia.TabIndex = 0;
            // 
            // panelMediaActions
            // 
            this.panelMediaActions.BackColor = System.Drawing.Color.Black;
            this.panelMediaActions.Controls.Add(this.btnAddImage);
            this.panelMediaActions.Controls.Add(this.btnAddVideo);
            this.panelMediaActions.Controls.Add(this.btnAddSticker);
            this.panelMediaActions.Controls.Add(this.btnDeleteMedia);
            this.panelMediaActions.Controls.Add(this.btnMoveUp);
            this.panelMediaActions.Controls.Add(this.btnMoveDown);
            this.panelMediaActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMediaActions.Location = new System.Drawing.Point(0, 441);
            this.panelMediaActions.Name = "panelMediaActions";
            this.panelMediaActions.Size = new System.Drawing.Size(992, 56);
            this.panelMediaActions.TabIndex = 1;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.White;
            this.btnAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImage.FlatAppearance.BorderSize = 0;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddImage.ForeColor = System.Drawing.Color.Black;
            this.btnAddImage.Location = new System.Drawing.Point(10, 10);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(120, 36);
            this.btnAddImage.TabIndex = 0;
            this.btnAddImage.Text = "+ Add Image";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.BackColor = System.Drawing.Color.White;
            this.btnAddVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVideo.FlatAppearance.BorderSize = 0;
            this.btnAddVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVideo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddVideo.ForeColor = System.Drawing.Color.Black;
            this.btnAddVideo.Location = new System.Drawing.Point(140, 10);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(120, 36);
            this.btnAddVideo.TabIndex = 1;
            this.btnAddVideo.Text = "+ Add Video";
            this.btnAddVideo.UseVisualStyleBackColor = false;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // btnAddSticker
            // 
            this.btnAddSticker.BackColor = System.Drawing.Color.White;
            this.btnAddSticker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSticker.FlatAppearance.BorderSize = 0;
            this.btnAddSticker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSticker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddSticker.ForeColor = System.Drawing.Color.Black;
            this.btnAddSticker.Location = new System.Drawing.Point(270, 10);
            this.btnAddSticker.Name = "btnAddSticker";
            this.btnAddSticker.Size = new System.Drawing.Size(120, 36);
            this.btnAddSticker.TabIndex = 2;
            this.btnAddSticker.Text = "+ Add Sticker";
            this.btnAddSticker.UseVisualStyleBackColor = false;
            this.btnAddSticker.Click += new System.EventHandler(this.btnAddSticker_Click);
            // 
            // btnDeleteMedia
            // 
            this.btnDeleteMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMedia.FlatAppearance.BorderSize = 0;
            this.btnDeleteMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMedia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteMedia.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMedia.Location = new System.Drawing.Point(396, 10);
            this.btnDeleteMedia.Name = "btnDeleteMedia";
            this.btnDeleteMedia.Size = new System.Drawing.Size(120, 36);
            this.btnDeleteMedia.TabIndex = 3;
            this.btnDeleteMedia.Text = "X Delete";
            this.btnDeleteMedia.UseVisualStyleBackColor = false;
            this.btnDeleteMedia.Click += new System.EventHandler(this.btnDeleteMedia_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.Color.Moccasin;
            this.btnMoveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveUp.FlatAppearance.BorderSize = 0;
            this.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMoveUp.ForeColor = System.Drawing.Color.Black;
            this.btnMoveUp.Location = new System.Drawing.Point(522, 10);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(100, 36);
            this.btnMoveUp.TabIndex = 4;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.Color.Moccasin;
            this.btnMoveDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveDown.FlatAppearance.BorderSize = 0;
            this.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMoveDown.ForeColor = System.Drawing.Color.Black;
            this.btnMoveDown.Location = new System.Drawing.Point(628, 10);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(110, 36);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // tabRatings
            // 
            this.tabRatings.BackColor = System.Drawing.Color.White;
            this.tabRatings.Controls.Add(this.dgvRatings);
            this.tabRatings.Controls.Add(this.panelRatingActions);
            this.tabRatings.Location = new System.Drawing.Point(4, 29);
            this.tabRatings.Name = "tabRatings";
            this.tabRatings.Size = new System.Drawing.Size(992, 497);
            this.tabRatings.TabIndex = 1;
            this.tabRatings.Text = "  Ratings & Feedback  ";
            // 
            // dgvRatings
            // 
            this.dgvRatings.AllowUserToAddRows = false;
            this.dgvRatings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRatings.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvRatings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRatings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRatings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRatId,
            this.colRatCustomer,
            this.colRatStars,
            this.colRatFeedback,
            this.colRatReply,
            this.colRatDate});
            this.dgvRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRatings.EnableHeadersVisualStyles = false;
            this.dgvRatings.Location = new System.Drawing.Point(0, 0);
            this.dgvRatings.MultiSelect = false;
            this.dgvRatings.Name = "dgvRatings";
            this.dgvRatings.ReadOnly = true;
            this.dgvRatings.RowHeadersVisible = false;
            this.dgvRatings.RowTemplate.Height = 40;
            this.dgvRatings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRatings.Size = new System.Drawing.Size(992, 441);
            this.dgvRatings.TabIndex = 0;
            // 
            // colRatId
            // 
            this.colRatId.HeaderText = "ID";
            this.colRatId.Name = "colRatId";
            this.colRatId.ReadOnly = true;
            this.colRatId.Visible = false;
            this.colRatId.Width = 50;
            // 
            // colRatCustomer
            // 
            this.colRatCustomer.HeaderText = "Customer";
            this.colRatCustomer.Name = "colRatCustomer";
            this.colRatCustomer.ReadOnly = true;
            this.colRatCustomer.Width = 180;
            // 
            // colRatStars
            // 
            this.colRatStars.HeaderText = "Stars";
            this.colRatStars.Name = "colRatStars";
            this.colRatStars.ReadOnly = true;
            // 
            // colRatFeedback
            // 
            this.colRatFeedback.HeaderText = "Feedback";
            this.colRatFeedback.Name = "colRatFeedback";
            this.colRatFeedback.ReadOnly = true;
            this.colRatFeedback.Width = 250;
            // 
            // colRatReply
            // 
            this.colRatReply.HeaderText = "Admin Reply";
            this.colRatReply.Name = "colRatReply";
            this.colRatReply.ReadOnly = true;
            this.colRatReply.Width = 250;
            // 
            // colRatDate
            // 
            this.colRatDate.HeaderText = "Date";
            this.colRatDate.Name = "colRatDate";
            this.colRatDate.ReadOnly = true;
            // 
            // panelRatingActions
            // 
            this.panelRatingActions.BackColor = System.Drawing.Color.White;
            this.panelRatingActions.Controls.Add(this.btnReplyRating);
            this.panelRatingActions.Controls.Add(this.btnHideRating);
            this.panelRatingActions.Controls.Add(this.lblRatingSummary);
            this.panelRatingActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRatingActions.Location = new System.Drawing.Point(0, 441);
            this.panelRatingActions.Name = "panelRatingActions";
            this.panelRatingActions.Size = new System.Drawing.Size(992, 56);
            this.panelRatingActions.TabIndex = 1;
            // 
            // btnReplyRating
            // 
            this.btnReplyRating.BackColor = System.Drawing.Color.Black;
            this.btnReplyRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplyRating.FlatAppearance.BorderSize = 0;
            this.btnReplyRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplyRating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReplyRating.ForeColor = System.Drawing.Color.White;
            this.btnReplyRating.Location = new System.Drawing.Point(10, 10);
            this.btnReplyRating.Name = "btnReplyRating";
            this.btnReplyRating.Size = new System.Drawing.Size(150, 36);
            this.btnReplyRating.TabIndex = 0;
            this.btnReplyRating.Text = "Reply to Review";
            this.btnReplyRating.UseVisualStyleBackColor = false;
            this.btnReplyRating.Click += new System.EventHandler(this.btnReplyRating_Click);
            // 
            // btnHideRating
            // 
            this.btnHideRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHideRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHideRating.FlatAppearance.BorderSize = 0;
            this.btnHideRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideRating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHideRating.ForeColor = System.Drawing.Color.White;
            this.btnHideRating.Location = new System.Drawing.Point(170, 10);
            this.btnHideRating.Name = "btnHideRating";
            this.btnHideRating.Size = new System.Drawing.Size(120, 36);
            this.btnHideRating.TabIndex = 1;
            this.btnHideRating.Text = "Hide Review";
            this.btnHideRating.UseVisualStyleBackColor = false;
            this.btnHideRating.Click += new System.EventHandler(this.btnHideRating_Click);
            // 
            // lblRatingSummary
            // 
            this.lblRatingSummary.AutoSize = true;
            this.lblRatingSummary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRatingSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblRatingSummary.Location = new System.Drawing.Point(330, 18);
            this.lblRatingSummary.Name = "lblRatingSummary";
            this.lblRatingSummary.Size = new System.Drawing.Size(0, 19);
            this.lblRatingSummary.TabIndex = 2;
            // 
            // tabOrders
            // 
            this.tabOrders.BackColor = System.Drawing.Color.White;
            this.tabOrders.Controls.Add(this.dgvOrders);
            this.tabOrders.Controls.Add(this.lblOrderSummary);
            this.tabOrders.Location = new System.Drawing.Point(4, 29);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Size = new System.Drawing.Size(992, 497);
            this.tabOrders.TabIndex = 2;
            this.tabOrders.Text = "  Orders  ";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrdId,
            this.colOrdDate,
            this.colOrdLocation,
            this.colOrdType,
            this.colOrdName,
            this.colOrdTotal,
            this.colOrdStatus});
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowTemplate.Height = 40;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(992, 467);
            this.dgvOrders.TabIndex = 0;
            // 
            // colOrdId
            // 
            this.colOrdId.HeaderText = "Order ID";
            this.colOrdId.Name = "colOrdId";
            this.colOrdId.ReadOnly = true;
            this.colOrdId.Width = 80;
            // 
            // colOrdDate
            // 
            this.colOrdDate.HeaderText = "Event Date";
            this.colOrdDate.Name = "colOrdDate";
            this.colOrdDate.ReadOnly = true;
            this.colOrdDate.Width = 110;
            // 
            // colOrdLocation
            // 
            this.colOrdLocation.HeaderText = "Location";
            this.colOrdLocation.Name = "colOrdLocation";
            this.colOrdLocation.ReadOnly = true;
            this.colOrdLocation.Width = 200;
            // 
            // colOrdType
            // 
            this.colOrdType.HeaderText = "Event Type";
            this.colOrdType.Name = "colOrdType";
            this.colOrdType.ReadOnly = true;
            this.colOrdType.Width = 130;
            // 
            // colOrdName
            // 
            this.colOrdName.HeaderText = "Celebrant";
            this.colOrdName.Name = "colOrdName";
            this.colOrdName.ReadOnly = true;
            this.colOrdName.Width = 150;
            // 
            // colOrdTotal
            // 
            this.colOrdTotal.HeaderText = "Total";
            this.colOrdTotal.Name = "colOrdTotal";
            this.colOrdTotal.ReadOnly = true;
            this.colOrdTotal.Width = 110;
            // 
            // colOrdStatus
            // 
            this.colOrdStatus.HeaderText = "Status";
            this.colOrdStatus.Name = "colOrdStatus";
            this.colOrdStatus.ReadOnly = true;
            this.colOrdStatus.Width = 110;
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.lblOrderSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblOrderSummary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOrderSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblOrderSummary.Location = new System.Drawing.Point(0, 467);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblOrderSummary.Size = new System.Drawing.Size(992, 30);
            this.lblOrderSummary.TabIndex = 1;
            this.lblOrderSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Black;
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 610);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1000, 50);
            this.panelBottom.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.Location = new System.Drawing.Point(16, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAdminPackageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelBottom);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmAdminPackageDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Package Details - Admin";
            this.Load += new System.EventHandler(this.frmAdminPackageDetails_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMedia.ResumeLayout(false);
            this.panelMediaActions.ResumeLayout(false);
            this.tabRatings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).EndInit();
            this.panelRatingActions.ResumeLayout(false);
            this.panelRatingActions.PerformLayout();
            this.tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Label lblHeaderStatus;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMedia;
        private System.Windows.Forms.TabPage tabRatings;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.FlowLayoutPanel flowMedia;
        private System.Windows.Forms.Panel panelMediaActions;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.Button btnAddSticker;
        private System.Windows.Forms.Button btnDeleteMedia;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.DataGridView dgvRatings;
        private System.Windows.Forms.Panel panelRatingActions;
        private System.Windows.Forms.Button btnReplyRating;
        private System.Windows.Forms.Button btnHideRating;
        private System.Windows.Forms.Label lblRatingSummary;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRatCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRatStars;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRatFeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRatReply;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRatDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrdLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrdTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrdStatus;
    }
}
