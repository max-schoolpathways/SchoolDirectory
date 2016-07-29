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
    public partial class MainWindow : Form
    {
        public static MainWindow Form;
        public List<string> schoolNames = new List<string>(); 
        public List<string> contactNames = new List<string>(); 
        public BindingSource schoolSource = new BindingSource();
        public BindingSource contactSource = new BindingSource();
        public MainWindow()
        {
            InitializeComponent();
            Form = this;
            schoolSource.DataSource = SchoolEntry.allSchools;
            //contactSource.DataSource = SchoolEntry.currentEntry.schoolContacts;
            GroupList.DataSource = schoolSource;
            RecordList.DataSource = contactSource;
        }

        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SchoolEntry.currentEntry = AppController.GetSchool(GroupList.SelectedItem.ToString());
            formRefresh();
            /*
            for(var i = 0;i < SchoolEntry.currentEntry.schoolContacts.Count(); i++)
            {
                RecordList.Items[i] = SchoolEntry.currentEntry.schoolContacts[i].contactName;
            }
            */
        }

        private void newGroupButton_Click(object sender, EventArgs e)
        {
            EntryBuilder.mode = EntryBuilder.modeEnum.Group;
            new NewEntryForm().Show();
        }
        public void formRefresh()
        {
           // GroupList.Items.Clear();
            //RecordList.Items.Clear();
            
            schoolNames.Clear();
            contactNames.Clear();

            foreach(var school in SchoolEntry.allSchools)
            {
                schoolNames.Add(school.schoolScope);
            }
            
            schoolSource.DataSource = schoolNames;
            GroupList.DataSource = schoolSource;
            schoolSource.ResetBindings(false);
            if (SchoolEntry.currentEntry != null)
            {
                foreach(ContactEntry contact in SchoolEntry.currentEntry.schoolContacts)
                {
                    contactNames.Add(contact.contactName);
                }
                contactSource.DataSource = contactNames;
                RecordList.DataSource = contactSource;
                contactSource.ResetBindings(false);
            }
            
            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            formRefresh();
        }

        private void newRecordButton_Click(object sender, EventArgs e)
        {
            EntryBuilder.mode = EntryBuilder.modeEnum.Contact;
            new NewEntryForm().Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //AppController.saveAll();
            //SchoolEntry.currentEntry.schoolNotes = schoolNotebox.Text;
            saveRecord();
        }
        void saveRecord()
        {
            SchoolEntry.currentEntry.schoolNotes = schoolNotebox.Text;

            ContactEntry.currentContact.contactEmail = emailField.Text;
            ContactEntry.currentContact.contactName = nameField.Text;
            ContactEntry.currentContact.contactNotes = contactNoteBox.Text;
            ContactEntry.currentContact.contactPhone1 = phoneField1.Text;
            ContactEntry.currentContact.contactPhone2 = phoneField2.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            AppController.breakpoint();
        }
    }
}
