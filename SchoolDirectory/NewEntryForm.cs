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
    public partial class NewEntryForm : Form
    {
        public NewEntryForm()
        {
            InitializeComponent();
        }

        private void NewEntryForm_Load(object sender, EventArgs e)
        {
            groupList.DataSource = MainWindow.Form.schoolNames;

            if (EntryBuilder.mode == EntryBuilder.modeEnum.Contact)
            {
                groupList.Visible = true;
                groupLabel.Visible = true;
                for(var i = 0; i <= SchoolEntry.allSchools.Count; i++)
                {
                    groupList.Items[i] = SchoolEntry.allSchools[i];
                }


            }
            else
            {
                groupList.Visible = false;
                groupLabel.Visible = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(EntryBuilder.mode == EntryBuilder.modeEnum.Contact)
            {
                ContactEntry newContact = new ContactEntry();
                newContact.contactName = nameField.Text;
                newContact.contactSchool = SchoolEntry.allSchools[groupList.SelectedIndex];
                newContact.contactSchool.schoolContacts.Add(newContact);
            }
            else
            {
                SchoolEntry newSchool = new SchoolEntry();
                newSchool.schoolScope = nameField.Text;
                SchoolEntry.allSchools.Add(newSchool);
            }
            MainWindow.Form.formRefresh();
            NewEntryForm.ActiveForm.Close();
        }
    }
}
