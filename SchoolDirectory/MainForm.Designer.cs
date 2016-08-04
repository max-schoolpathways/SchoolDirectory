namespace SchoolDirectory
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.WrapperTable = new System.Windows.Forms.TableLayoutPanel();
            this.MainWindowToolstrip = new System.Windows.Forms.ToolStrip();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.RecordStatusStrip = new System.Windows.Forms.StatusStrip();
            this.currentRecordDetails = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainWindowTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.positionField = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.phoneField2 = new System.Windows.Forms.TextBox();
            this.phoneLabel2 = new System.Windows.Forms.Label();
            this.phoneField1 = new System.Windows.Forms.TextBox();
            this.phoneLabel1 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.LinkLabel();
            this.nameField = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.noteGroupBox = new System.Windows.Forms.GroupBox();
            this.contactNoteBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.schoolNotebox = new System.Windows.Forms.RichTextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.RecordList = new System.Windows.Forms.ListBox();
            this.contactEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupList = new System.Windows.Forms.ListBox();
            this.schoolEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newGroupButton = new System.Windows.Forms.Button();
            this.newRecordButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contactDeleteButton = new System.Windows.Forms.Button();
            this.contactSavebutton = new System.Windows.Forms.Button();
            this.isDirectorCheckbox = new System.Windows.Forms.CheckBox();
            this.isPrimaryContactCheckbox = new System.Windows.Forms.CheckBox();
            this.WrapperTable.SuspendLayout();
            this.MainWindowToolstrip.SuspendLayout();
            this.RecordStatusStrip.SuspendLayout();
            this.MainWindowTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.noteGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEntryBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WrapperTable
            // 
            this.WrapperTable.ColumnCount = 1;
            this.WrapperTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WrapperTable.Controls.Add(this.MainWindowToolstrip, 0, 0);
            this.WrapperTable.Controls.Add(this.RecordStatusStrip, 0, 2);
            this.WrapperTable.Controls.Add(this.MainWindowTable, 0, 1);
            this.WrapperTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WrapperTable.Location = new System.Drawing.Point(0, 0);
            this.WrapperTable.Name = "WrapperTable";
            this.WrapperTable.RowCount = 3;
            this.WrapperTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.12468F));
            this.WrapperTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.82442F));
            this.WrapperTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.30534F));
            this.WrapperTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.WrapperTable.Size = new System.Drawing.Size(644, 420);
            this.WrapperTable.TabIndex = 1;
            // 
            // MainWindowToolstrip
            // 
            this.MainWindowToolstrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshButton,
            this.saveButton,
            this.deleteButton});
            this.MainWindowToolstrip.Location = new System.Drawing.Point(0, 0);
            this.MainWindowToolstrip.Name = "MainWindowToolstrip";
            this.MainWindowToolstrip.Size = new System.Drawing.Size(644, 29);
            this.MainWindowToolstrip.TabIndex = 0;
            this.MainWindowToolstrip.Text = "toolStrip1";
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(23, 26);
            this.refreshButton.Text = "toolStripButton1";
            this.refreshButton.ToolTipText = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 26);
            this.saveButton.Text = "toolStripButton1";
            this.saveButton.ToolTipText = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(23, 26);
            this.deleteButton.Text = "toolStripButton1";
            this.deleteButton.ToolTipText = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // RecordStatusStrip
            // 
            this.RecordStatusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentRecordDetails});
            this.RecordStatusStrip.Location = new System.Drawing.Point(0, 375);
            this.RecordStatusStrip.Name = "RecordStatusStrip";
            this.RecordStatusStrip.Size = new System.Drawing.Size(644, 45);
            this.RecordStatusStrip.TabIndex = 1;
            this.RecordStatusStrip.Text = "statusStrip1";
            // 
            // currentRecordDetails
            // 
            this.currentRecordDetails.Name = "currentRecordDetails";
            this.currentRecordDetails.Size = new System.Drawing.Size(117, 40);
            this.currentRecordDetails.Text = "currentRecordDetails";
            this.currentRecordDetails.Click += new System.EventHandler(this.currentRecordDetails_Click);
            // 
            // MainWindowTable
            // 
            this.MainWindowTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainWindowTable.ColumnCount = 3;
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 407F));
            this.MainWindowTable.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.MainWindowTable.Controls.Add(this.RecordList, 1, 0);
            this.MainWindowTable.Controls.Add(this.GroupList, 0, 0);
            this.MainWindowTable.Controls.Add(this.newGroupButton, 0, 1);
            this.MainWindowTable.Controls.Add(this.newRecordButton, 1, 1);
            this.MainWindowTable.Controls.Add(this.flowLayoutPanel1, 2, 1);
            this.MainWindowTable.Location = new System.Drawing.Point(3, 32);
            this.MainWindowTable.Name = "MainWindowTable";
            this.MainWindowTable.RowCount = 2;
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainWindowTable.Size = new System.Drawing.Size(638, 340);
            this.MainWindowTable.TabIndex = 2;
            this.MainWindowTable.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindowTable_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.36111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.63889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.Controls.Add(this.nameField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.loginField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailField, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.positionLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.positionField, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.phoneField2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.phoneField1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.phoneLabel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.phoneLabel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.loginLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.noteGroupBox, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.isDirectorCheckbox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.isPrimaryContactCheckbox, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(182, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 305);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // positionField
            // 
            this.positionField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.positionField.Location = new System.Drawing.Point(304, 36);
            this.positionField.Name = "positionField";
            this.positionField.Size = new System.Drawing.Size(91, 20);
            this.positionField.TabIndex = 2;
            this.positionField.Text = "Position";
            // 
            // positionLabel
            // 
            this.positionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(254, 40);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(44, 13);
            this.positionLabel.TabIndex = 1;
            this.positionLabel.Text = "Position";
            // 
            // phoneField2
            // 
            this.phoneField2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneField2.Location = new System.Drawing.Point(304, 69);
            this.phoneField2.Name = "phoneField2";
            this.phoneField2.Size = new System.Drawing.Size(92, 20);
            this.phoneField2.TabIndex = 0;
            this.phoneField2.Text = "Phone2";
            // 
            // phoneLabel2
            // 
            this.phoneLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.phoneLabel2.AutoSize = true;
            this.phoneLabel2.Location = new System.Drawing.Point(248, 72);
            this.phoneLabel2.Name = "phoneLabel2";
            this.phoneLabel2.Size = new System.Drawing.Size(50, 13);
            this.phoneLabel2.TabIndex = 1;
            this.phoneLabel2.Text = "Phone 2:";
            // 
            // phoneField1
            // 
            this.phoneField1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneField1.Location = new System.Drawing.Point(96, 69);
            this.phoneField1.Name = "phoneField1";
            this.phoneField1.Size = new System.Drawing.Size(80, 20);
            this.phoneField1.TabIndex = 0;
            this.phoneField1.Text = "Phone1";
            // 
            // phoneLabel1
            // 
            this.phoneLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.phoneLabel1.AutoSize = true;
            this.phoneLabel1.Location = new System.Drawing.Point(40, 72);
            this.phoneLabel1.Name = "phoneLabel1";
            this.phoneLabel1.Size = new System.Drawing.Size(50, 13);
            this.phoneLabel1.TabIndex = 1;
            this.phoneLabel1.Tag = "";
            this.phoneLabel1.Text = "Phone 1:";
            // 
            // emailField
            // 
            this.emailField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailField.Location = new System.Drawing.Point(304, 5);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(92, 20);
            this.emailField.TabIndex = 0;
            this.emailField.Text = "Contact Email";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.emailLabel.AutoSize = true;
            this.emailLabel.LinkColor = System.Drawing.Color.Navy;
            this.emailLabel.Location = new System.Drawing.Point(266, 8);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.TabStop = true;
            this.emailLabel.Text = "Email";
            this.emailLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLabel_LinkClicked);
            // 
            // nameField
            // 
            this.nameField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameField.Location = new System.Drawing.Point(96, 5);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(91, 20);
            this.nameField.TabIndex = 0;
            this.nameField.Text = "Contact Name";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(52, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // noteGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.noteGroupBox, 2);
            this.noteGroupBox.Controls.Add(this.contactNoteBox);
            this.noteGroupBox.Location = new System.Drawing.Point(222, 132);
            this.noteGroupBox.Name = "noteGroupBox";
            this.noteGroupBox.Size = new System.Drawing.Size(221, 170);
            this.noteGroupBox.TabIndex = 9;
            this.noteGroupBox.TabStop = false;
            this.noteGroupBox.Text = "Contact Notes";
            // 
            // contactNoteBox
            // 
            this.contactNoteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactNoteBox.Location = new System.Drawing.Point(3, 16);
            this.contactNoteBox.Name = "contactNoteBox";
            this.contactNoteBox.Size = new System.Drawing.Size(215, 151);
            this.contactNoteBox.TabIndex = 4;
            this.contactNoteBox.Text = "Contact Notes";
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.schoolNotebox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 170);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "School Notes";
            // 
            // schoolNotebox
            // 
            this.schoolNotebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schoolNotebox.Location = new System.Drawing.Point(3, 16);
            this.schoolNotebox.Name = "schoolNotebox";
            this.schoolNotebox.Size = new System.Drawing.Size(207, 151);
            this.schoolNotebox.TabIndex = 5;
            this.schoolNotebox.Text = "School Notes";
            // 
            // loginField
            // 
            this.loginField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginField.Location = new System.Drawing.Point(96, 36);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(91, 20);
            this.loginField.TabIndex = 1;
            this.loginField.Text = "Login";
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(57, 40);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // RecordList
            // 
            this.RecordList.DataSource = this.contactEntryBindingSource;
            this.RecordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordList.FormattingEnabled = true;
            this.RecordList.Location = new System.Drawing.Point(88, 3);
            this.RecordList.Name = "RecordList";
            this.RecordList.Size = new System.Drawing.Size(88, 305);
            this.RecordList.TabIndex = 1;
            this.RecordList.SelectedIndexChanged += new System.EventHandler(this.RecordList_SelectedIndexChanged);
            // 
            // contactEntryBindingSource
            // 
            this.contactEntryBindingSource.DataSource = typeof(SchoolClasses.ContactEntry);
            // 
            // GroupList
            // 
            this.GroupList.DataSource = this.schoolEntryBindingSource;
            this.GroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(3, 3);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(79, 305);
            this.GroupList.Sorted = true;
            this.GroupList.TabIndex = 0;
            this.GroupList.SelectedIndexChanged += new System.EventHandler(this.GroupList_SelectedIndexChanged);
            this.GroupList.DoubleClick += new System.EventHandler(this.GroupList_DoubleClick);
            // 
            // schoolEntryBindingSource
            // 
            this.schoolEntryBindingSource.DataSource = typeof(SchoolClasses.SchoolEntry);
            // 
            // newGroupButton
            // 
            this.newGroupButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newGroupButton.Location = new System.Drawing.Point(3, 314);
            this.newGroupButton.Name = "newGroupButton";
            this.newGroupButton.Size = new System.Drawing.Size(79, 23);
            this.newGroupButton.TabIndex = 3;
            this.newGroupButton.Text = "New Group";
            this.newGroupButton.UseVisualStyleBackColor = true;
            this.newGroupButton.Click += new System.EventHandler(this.newGroupButton_Click);
            // 
            // newRecordButton
            // 
            this.newRecordButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newRecordButton.Location = new System.Drawing.Point(88, 314);
            this.newRecordButton.Name = "newRecordButton";
            this.newRecordButton.Size = new System.Drawing.Size(88, 23);
            this.newRecordButton.TabIndex = 4;
            this.newRecordButton.Text = "New Record";
            this.newRecordButton.UseVisualStyleBackColor = true;
            this.newRecordButton.Click += new System.EventHandler(this.newRecordButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.contactDeleteButton);
            this.flowLayoutPanel1.Controls.Add(this.contactSavebutton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(179, 311);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // contactDeleteButton
            // 
            this.contactDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.contactDeleteButton.AutoSize = true;
            this.contactDeleteButton.Location = new System.Drawing.Point(370, 3);
            this.contactDeleteButton.Name = "contactDeleteButton";
            this.contactDeleteButton.Size = new System.Drawing.Size(86, 23);
            this.contactDeleteButton.TabIndex = 6;
            this.contactDeleteButton.Text = "Delete Record";
            this.contactDeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contactDeleteButton.UseVisualStyleBackColor = true;
            this.contactDeleteButton.Click += new System.EventHandler(this.contactDeleteButton_Click);
            // 
            // contactSavebutton
            // 
            this.contactSavebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.contactSavebutton.AutoSize = true;
            this.contactSavebutton.Location = new System.Drawing.Point(284, 3);
            this.contactSavebutton.Name = "contactSavebutton";
            this.contactSavebutton.Size = new System.Drawing.Size(80, 23);
            this.contactSavebutton.TabIndex = 5;
            this.contactSavebutton.Text = "Save Record";
            this.contactSavebutton.UseVisualStyleBackColor = true;
            this.contactSavebutton.Click += new System.EventHandler(this.contactSavebutton_Click);
            // 
            // isDirectorCheckbox
            // 
            this.isDirectorCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.isDirectorCheckbox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.isDirectorCheckbox, 2);
            this.isDirectorCheckbox.Location = new System.Drawing.Point(142, 103);
            this.isDirectorCheckbox.Name = "isDirectorCheckbox";
            this.isDirectorCheckbox.Size = new System.Drawing.Size(74, 17);
            this.isDirectorCheckbox.TabIndex = 13;
            this.isDirectorCheckbox.Text = "Is Director";
            this.isDirectorCheckbox.UseVisualStyleBackColor = true;
            // 
            // isPrimaryContactCheckbox
            // 
            this.isPrimaryContactCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.isPrimaryContactCheckbox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.isPrimaryContactCheckbox, 2);
            this.isPrimaryContactCheckbox.Location = new System.Drawing.Point(339, 103);
            this.isPrimaryContactCheckbox.Name = "isPrimaryContactCheckbox";
            this.isPrimaryContactCheckbox.Size = new System.Drawing.Size(111, 17);
            this.isPrimaryContactCheckbox.TabIndex = 14;
            this.isPrimaryContactCheckbox.Text = "Is Primary Contact";
            this.isPrimaryContactCheckbox.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 420);
            this.Controls.Add(this.WrapperTable);
            this.Name = "MainWindow";
            this.Text = "SchoolDirectory";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.WrapperTable.ResumeLayout(false);
            this.WrapperTable.PerformLayout();
            this.MainWindowToolstrip.ResumeLayout(false);
            this.MainWindowToolstrip.PerformLayout();
            this.RecordStatusStrip.ResumeLayout(false);
            this.RecordStatusStrip.PerformLayout();
            this.MainWindowTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.noteGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contactEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEntryBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel WrapperTable;
        private System.Windows.Forms.ToolStrip MainWindowToolstrip;
        private System.Windows.Forms.StatusStrip RecordStatusStrip;
        private System.Windows.Forms.TableLayoutPanel MainWindowTable;
        private System.Windows.Forms.ListBox RecordList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox contactNoteBox;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.TextBox phoneField2;
        private System.Windows.Forms.Label phoneLabel2;
        private System.Windows.Forms.TextBox phoneField1;
        private System.Windows.Forms.Label phoneLabel1;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox noteGroupBox;
        private System.Windows.Forms.ToolStripStatusLabel currentRecordDetails;
        private System.Windows.Forms.ListBox GroupList;
        private System.Windows.Forms.Button newGroupButton;
        private System.Windows.Forms.Button newRecordButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox schoolNotebox;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.BindingSource schoolEntryBindingSource;
        private System.Windows.Forms.BindingSource contactEntryBindingSource;
        private System.Windows.Forms.Button contactSavebutton;
        private System.Windows.Forms.TextBox positionField;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button contactDeleteButton;
        private System.Windows.Forms.LinkLabel emailLabel;
        private System.Windows.Forms.CheckBox isDirectorCheckbox;
        private System.Windows.Forms.CheckBox isPrimaryContactCheckbox;
    }
}

