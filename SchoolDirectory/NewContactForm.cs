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
            groupList.DataSource = MainWindow.Form.schoolSource;
            groupList.DisplayMember = "schoolScope";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
            ContactEntry newContact = new ContactEntry(nameField.Text);
            newContact.contactSchool = groupList.SelectedItem as SchoolEntry;
            
            newContact.contactSchool.schoolContacts.Add(newContact);
            ContactEntry.allEntries.Add(newContact);
            ContactEntry.currentContact = newContact;

           
            MainWindow.Form.formRefresh();
            NewContactForm.ActiveForm.Close();
        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
