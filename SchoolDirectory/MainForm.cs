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
            AppController.loadRecords();
            schoolSource.DataSource = SchoolEntry.allSchools;
            GroupList.DataSource = schoolSource;
            RecordList.DataSource = contactSource;
        }

        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SchoolEntry.currentEntry = AppController.GetSchool(GroupList.SelectedItem.ToString());
            formRefresh();
        }

        private void newGroupButton_Click(object sender, EventArgs e)
        {
            EntryBuilder.mode = EntryBuilder.modeEnum.Group;
            new NewEntryForm().Show();
        }
        public void formRefresh()
        {
            //AppController.saveRecords();
           // AppController.loadRecords();
            //Old refresh method
             
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
                    contactNames.Add(contact.contactLogin);
                }
                contactSource.DataSource = contactNames;
                RecordList.DataSource = contactSource;
                contactSource.ResetBindings(false);



            }
            
            
        }

        void loadFields(ContactEntry contact)
        {
            phoneField1.Text = contact.contactPhone1;
            phoneField2.Text = contact.contactPhone2;
            loginField.Text = contact.contactLogin;
            positionField.Text = contact.contactPosition;
            nameField.Text = contact.contactName;
            emailField.Text = contact.contactEmail;
            schoolNotebox.Text = contact.contactSchool.schoolNotes;
            contactNoteBox.Text = contact.contactNotes;
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
            saveRecord();
        }
        void saveRecord()
        {
            SchoolEntry.currentEntry.schoolNotes = schoolNotebox.Text;

            ContactEntry.currentContact.contactEmail = emailField.Text;
            ContactEntry.currentContact.contactName = nameField.Text;
            ContactEntry.currentContact.contactLogin = loginField.Text;
            ContactEntry.currentContact.contactPosition = positionField.Text;
            ContactEntry.currentContact.contactNotes = contactNoteBox.Text;
            ContactEntry.currentContact.contactPhone1 = phoneField1.Text;
            ContactEntry.currentContact.contactPhone2 = phoneField2.Text;

        }
        void loadRecord()
        {

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            AppController.breakpoint();
        }

        private void contactSavebutton_Click(object sender, EventArgs e)
        {
            SchoolEntry.currentEntry.schoolNotes = schoolNotebox.Text;
            ContactEntry.currentContact.contactName = nameField.Text;
            ContactEntry.currentContact.contactEmail = emailField.Text;
            ContactEntry.currentContact.contactPhone1 = phoneField1.Text;
            ContactEntry.currentContact.contactPhone2 = phoneField2.Text;
            ContactEntry.currentContact.contactNotes = contactNoteBox.Text;


            AppController.saveRecords();
        }

        private void RecordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactEntry.currentContact = AppController.GetContact(RecordList.SelectedItem.ToString());
            formRefresh();
            loadFields(ContactEntry.currentContact);
        }
    }
}
