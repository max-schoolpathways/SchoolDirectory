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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.WrapperTable = new System.Windows.Forms.TableLayoutPanel();
            this.MainWindowToolstrip = new System.Windows.Forms.ToolStrip();
            this.RecordStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainWindowTable = new System.Windows.Forms.TableLayoutPanel();
            this.GroupList = new System.Windows.Forms.ListBox();
            this.RecordList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.noteBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.nameField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.phoneField1 = new System.Windows.Forms.TextBox();
            this.phoneField2 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel1 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel2 = new System.Windows.Forms.Label();
            this.noteGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.currentRecordName = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentGroupName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastUpdatedDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.newRecordButton = new System.Windows.Forms.ToolStripButton();
            this.WrapperTable.SuspendLayout();
            this.MainWindowToolstrip.SuspendLayout();
            this.RecordStatusStrip.SuspendLayout();
            this.MainWindowTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.noteGroupBox.SuspendLayout();
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
            this.WrapperTable.Size = new System.Drawing.Size(592, 299);
            this.WrapperTable.TabIndex = 1;
            // 
            // MainWindowToolstrip
            // 
            this.MainWindowToolstrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRecordButton,
            this.saveButton,
            this.deleteButton});
            this.MainWindowToolstrip.Location = new System.Drawing.Point(0, 0);
            this.MainWindowToolstrip.Name = "MainWindowToolstrip";
            this.MainWindowToolstrip.Size = new System.Drawing.Size(592, 21);
            this.MainWindowToolstrip.TabIndex = 0;
            this.MainWindowToolstrip.Text = "toolStrip1";
            // 
            // RecordStatusStrip
            // 
            this.RecordStatusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentRecordName,
            this.currentGroupName,
            this.lastUpdatedDateTime});
            this.RecordStatusStrip.Location = new System.Drawing.Point(0, 268);
            this.RecordStatusStrip.Name = "RecordStatusStrip";
            this.RecordStatusStrip.Size = new System.Drawing.Size(592, 31);
            this.RecordStatusStrip.TabIndex = 1;
            this.RecordStatusStrip.Text = "statusStrip1";
            // 
            // MainWindowTable
            // 
            this.MainWindowTable.ColumnCount = 3;
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.82081F));
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.17919F));
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.MainWindowTable.Controls.Add(this.GroupList, 0, 0);
            this.MainWindowTable.Controls.Add(this.RecordList, 1, 0);
            this.MainWindowTable.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.MainWindowTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowTable.Location = new System.Drawing.Point(3, 24);
            this.MainWindowTable.Name = "MainWindowTable";
            this.MainWindowTable.RowCount = 1;
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainWindowTable.Size = new System.Drawing.Size(586, 241);
            this.MainWindowTable.TabIndex = 2;
            // 
            // GroupList
            // 
            this.GroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(3, 3);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(76, 235);
            this.GroupList.TabIndex = 0;
            // 
            // RecordList
            // 
            this.RecordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordList.FormattingEnabled = true;
            this.RecordList.Location = new System.Drawing.Point(85, 3);
            this.RecordList.Name = "RecordList";
            this.RecordList.Size = new System.Drawing.Size(87, 235);
            this.RecordList.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.noteGroupBox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(178, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 235);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // noteBox
            // 
            this.noteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteBox.Location = new System.Drawing.Point(3, 16);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(191, 151);
            this.noteBox.TabIndex = 4;
            this.noteBox.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.nameField, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(196, 24);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.emailField, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.emailLabel, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(205, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(196, 24);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.phoneField1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.phoneLabel1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(196, 23);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.phoneField2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.phoneLabel2, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(205, 33);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(196, 23);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // nameField
            // 
            this.nameField.Dock = System.Windows.Forms.DockStyle.Right;
            this.nameField.Location = new System.Drawing.Point(101, 3);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(92, 20);
            this.nameField.TabIndex = 0;
            // 
            // emailField
            // 
            this.emailField.Dock = System.Windows.Forms.DockStyle.Right;
            this.emailField.Location = new System.Drawing.Point(101, 3);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(92, 20);
            this.emailField.TabIndex = 0;
            // 
            // phoneField1
            // 
            this.phoneField1.Dock = System.Windows.Forms.DockStyle.Right;
            this.phoneField1.Location = new System.Drawing.Point(101, 3);
            this.phoneField1.Name = "phoneField1";
            this.phoneField1.Size = new System.Drawing.Size(92, 20);
            this.phoneField1.TabIndex = 0;
            // 
            // phoneField2
            // 
            this.phoneField2.Dock = System.Windows.Forms.DockStyle.Right;
            this.phoneField2.Location = new System.Drawing.Point(101, 3);
            this.phoneField2.Name = "phoneField2";
            this.phoneField2.Size = new System.Drawing.Size(92, 20);
            this.phoneField2.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(57, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // phoneLabel1
            // 
            this.phoneLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.phoneLabel1.AutoSize = true;
            this.phoneLabel1.Location = new System.Drawing.Point(45, 5);
            this.phoneLabel1.Name = "phoneLabel1";
            this.phoneLabel1.Size = new System.Drawing.Size(50, 13);
            this.phoneLabel1.TabIndex = 1;
            this.phoneLabel1.Tag = "";
            this.phoneLabel1.Text = "Phone 1:";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(60, 5);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            // 
            // phoneLabel2
            // 
            this.phoneLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.phoneLabel2.AutoSize = true;
            this.phoneLabel2.Location = new System.Drawing.Point(45, 5);
            this.phoneLabel2.Name = "phoneLabel2";
            this.phoneLabel2.Size = new System.Drawing.Size(50, 13);
            this.phoneLabel2.TabIndex = 1;
            this.phoneLabel2.Text = "Phone 2:";
            // 
            // noteGroupBox
            // 
            this.noteGroupBox.Controls.Add(this.noteBox);
            this.noteGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteGroupBox.Location = new System.Drawing.Point(205, 62);
            this.noteGroupBox.Name = "noteGroupBox";
            this.noteGroupBox.Size = new System.Drawing.Size(197, 170);
            this.noteGroupBox.TabIndex = 9;
            this.noteGroupBox.TabStop = false;
            this.noteGroupBox.Text = "Notes";
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 18);
            this.saveButton.Text = "toolStripButton1";
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(23, 18);
            this.deleteButton.Text = "toolStripButton1";
            // 
            // currentRecordName
            // 
            this.currentRecordName.Name = "currentRecordName";
            this.currentRecordName.Size = new System.Drawing.Size(114, 26);
            this.currentRecordName.Text = "currentRecordName";
            // 
            // currentGroupName
            // 
            this.currentGroupName.Name = "currentGroupName";
            this.currentGroupName.Size = new System.Drawing.Size(124, 26);
            this.currentGroupName.Text = "@ currentGroupName";
            // 
            // lastUpdatedDateTime
            // 
            this.lastUpdatedDateTime.Name = "lastUpdatedDateTime";
            this.lastUpdatedDateTime.Size = new System.Drawing.Size(193, 26);
            this.lastUpdatedDateTime.Text = "Last Updated lastUpdatedDateTime";
            // 
            // newRecordButton
            // 
            this.newRecordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newRecordButton.Image = ((System.Drawing.Image)(resources.GetObject("newRecordButton.Image")));
            this.newRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newRecordButton.Name = "newRecordButton";
            this.newRecordButton.Size = new System.Drawing.Size(23, 18);
            this.newRecordButton.Text = "toolStripButton1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 299);
            this.Controls.Add(this.WrapperTable);
            this.Name = "MainWindow";
            this.Text = "SchoolDirectory";
            this.WrapperTable.ResumeLayout(false);
            this.WrapperTable.PerformLayout();
            this.MainWindowToolstrip.ResumeLayout(false);
            this.MainWindowToolstrip.PerformLayout();
            this.RecordStatusStrip.ResumeLayout(false);
            this.RecordStatusStrip.PerformLayout();
            this.MainWindowTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.noteGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel WrapperTable;
        private System.Windows.Forms.ToolStrip MainWindowToolstrip;
        private System.Windows.Forms.StatusStrip RecordStatusStrip;
        private System.Windows.Forms.TableLayoutPanel MainWindowTable;
        private System.Windows.Forms.ListBox GroupList;
        private System.Windows.Forms.ListBox RecordList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox noteBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.TextBox phoneField2;
        private System.Windows.Forms.Label phoneLabel2;
        private System.Windows.Forms.TextBox phoneField1;
        private System.Windows.Forms.Label phoneLabel1;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox noteGroupBox;
        private System.Windows.Forms.ToolStripButton newRecordButton;
        private System.Windows.Forms.ToolStripStatusLabel currentRecordName;
        private System.Windows.Forms.ToolStripStatusLabel currentGroupName;
        private System.Windows.Forms.ToolStripStatusLabel lastUpdatedDateTime;
    }
}

