using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolClasses;

namespace SchoolDirectory
{
    public partial class GroupInfo : Form
    {
        private BindingSource productSource = new BindingSource();

        public GroupInfo()
        {
            InitializeComponent();
        }

        private void GroupInfo_Load(object sender, EventArgs e)
        {
            if(EntryBuilder.mode == EntryBuilder.modeEnum.Existing)
            {
                groupNameBox.Text = SchoolEntry.currentEntry.schoolName;
                scopeNameBox.Text = SchoolEntry.currentEntry.schoolScope;
                noteTextbox.Text = SchoolEntry.currentEntry.schoolNotes;
                productSource.DataSource = SchoolEntry.currentEntry.products;
                productsList.DataSource = productSource;
                productSource.ResetBindings(false);
                if (SchoolEntry.currentEntry.director != null)
                {
                    directorName.Text = SchoolEntry.currentEntry.director.contactName;
                }
                if (SchoolEntry.currentEntry.primaryContact != null)
                {
                    primaryContactName.Text = SchoolEntry.currentEntry.primaryContact.contactName;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(EntryBuilder.mode == EntryBuilder.modeEnum.Existing)
            {
                SchoolEntry.currentEntry.schoolName = groupNameBox.Text;
                SchoolEntry.currentEntry.schoolScope = scopeNameBox.Text;
                SchoolEntry.currentEntry.schoolNotes = noteTextbox.Text;
                MainWindow.Form.formRefresh();
                AppController.saveRecords();
                ActiveForm.Close();
            }else
            {
                SchoolEntry newSchool = new SchoolEntry(scopeNameBox.Text);
                if (!SchoolEntry.allSchools.Contains(newSchool))
                {
                    SchoolEntry.allSchools.Add(newSchool);
                }
                AppController.saveRecords();
                MainWindow.Form.formRefresh();
                ActiveForm.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(EntryBuilder.mode == EntryBuilder.modeEnum.New)
            {
                ActiveForm.Close();
            }else
            {
                SchoolEntry.currentEntry.Delete();
                AppController.saveRecords();
                MainWindow.Form.formRefresh();
                ;
                ActiveForm.Close();
            }
        }
    }
}
