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
            this.WrapperTable = new System.Windows.Forms.TableLayoutPanel();
            this.MainWindowToolstrip = new System.Windows.Forms.ToolStrip();
            this.RecordStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainWindowTable = new System.Windows.Forms.TableLayoutPanel();
            this.GroupList = new System.Windows.Forms.ListBox();
            this.RecordList = new System.Windows.Forms.ListBox();
            this.RecordPanel = new System.Windows.Forms.Panel();
            this.WrapperTable.SuspendLayout();
            this.MainWindowTable.SuspendLayout();
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
            this.WrapperTable.Size = new System.Drawing.Size(509, 262);
            this.WrapperTable.TabIndex = 1;
            // 
            // MainWindowToolstrip
            // 
            this.MainWindowToolstrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowToolstrip.Location = new System.Drawing.Point(0, 0);
            this.MainWindowToolstrip.Name = "MainWindowToolstrip";
            this.MainWindowToolstrip.Size = new System.Drawing.Size(509, 18);
            this.MainWindowToolstrip.TabIndex = 0;
            this.MainWindowToolstrip.Text = "toolStrip1";
            // 
            // RecordStatusStrip
            // 
            this.RecordStatusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordStatusStrip.Location = new System.Drawing.Point(0, 234);
            this.RecordStatusStrip.Name = "RecordStatusStrip";
            this.RecordStatusStrip.Size = new System.Drawing.Size(509, 28);
            this.RecordStatusStrip.TabIndex = 1;
            this.RecordStatusStrip.Text = "statusStrip1";
            // 
            // MainWindowTable
            // 
            this.MainWindowTable.ColumnCount = 3;
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.82081F));
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.17919F));
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.MainWindowTable.Controls.Add(this.GroupList, 0, 0);
            this.MainWindowTable.Controls.Add(this.RecordList, 1, 0);
            this.MainWindowTable.Controls.Add(this.RecordPanel, 2, 0);
            this.MainWindowTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowTable.Location = new System.Drawing.Point(3, 21);
            this.MainWindowTable.Name = "MainWindowTable";
            this.MainWindowTable.RowCount = 1;
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainWindowTable.Size = new System.Drawing.Size(503, 210);
            this.MainWindowTable.TabIndex = 2;
            // 
            // GroupList
            // 
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(3, 3);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(75, 95);
            this.GroupList.TabIndex = 0;
            // 
            // RecordList
            // 
            this.RecordList.FormattingEnabled = true;
            this.RecordList.Location = new System.Drawing.Point(84, 3);
            this.RecordList.Name = "RecordList";
            this.RecordList.Size = new System.Drawing.Size(86, 95);
            this.RecordList.TabIndex = 1;
            // 
            // RecordPanel
            // 
            this.RecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordPanel.Location = new System.Drawing.Point(176, 3);
            this.RecordPanel.Name = "RecordPanel";
            this.RecordPanel.Size = new System.Drawing.Size(324, 204);
            this.RecordPanel.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 262);
            this.Controls.Add(this.WrapperTable);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.WrapperTable.ResumeLayout(false);
            this.WrapperTable.PerformLayout();
            this.MainWindowTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel WrapperTable;
        private System.Windows.Forms.ToolStrip MainWindowToolstrip;
        private System.Windows.Forms.StatusStrip RecordStatusStrip;
        private System.Windows.Forms.TableLayoutPanel MainWindowTable;
        private System.Windows.Forms.ListBox GroupList;
        private System.Windows.Forms.ListBox RecordList;
        private System.Windows.Forms.Panel RecordPanel;
    }
}

