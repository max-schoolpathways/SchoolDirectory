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
    public partial class NewContactForm : Form
    {

        public NewContactForm()
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
                ContactEntry newContact = new ContactEntry(nameField.Text);
                newContact.contactSchool = AppController.GetSchool(groupList.SelectedItem.ToString());
                newContact.contactSchool.schoolContacts.Add(newContact);
                ContactEntry.allEntries.Add(newContact);
                ContactEntry.currentContact = newContact;

            }
            else
            {
                SchoolEntry newSchool = new SchoolEntry(nameField.Text);
                SchoolEntry.allSchools.Add(newSchool);
                if(SchoolEntry.currentEntry == null)
                {
                    SchoolEntry.currentEntry = newSchool;
                }
                

            }
            MainWindow.Form.formRefresh();
            NewContactForm.ActiveForm.Close();
        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
