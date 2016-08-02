﻿using System;
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
            
        }

        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SchoolEntry.currentEntry = AppController.GetSchool(GroupList.SelectedItem.ToString());
            //ContactEntry.currentContact = SchoolEntry.currentEntry.schoolContacts[0];
            ContactEntry.currentContact = null;
            RecordList.ClearSelected();
            clearFields();
            formRefresh();
        }

        private void newGroupButton_Click(object sender, EventArgs e)
        {
            EntryBuilder.mode = EntryBuilder.modeEnum.Group;
            new NewContactForm().Show();
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
           // schoolSource.DataSource = SchoolEntry.allSchools;
            GroupList.DataSource = schoolSource;
            //GroupList.DisplayMember = "schoolScope";
            //GroupList.ValueMember = "schoolScope";
            schoolSource.ResetBindings(true);
            if (SchoolEntry.currentEntry != null)
            {
                foreach(ContactEntry contact in SchoolEntry.currentEntry.schoolContacts)
                {
                    contactNames.Add(contact.contactLogin);
                }
                contactSource.DataSource = contactNames;
                RecordList.DataSource = contactSource;
                contactSource.ResetBindings(true);
            }
            updateStatusLabel();
            
        }
        void clearFields()
        {
            phoneField1.Text = null;
            phoneField2.Text = null;
            loginField.Text = null;
            positionField.Text = null;
            nameField.Text = null;
            emailField.Text = null;
            schoolNotebox.Text = null;
            contactNoteBox.Text = null;
        }
        void loadFields(ContactEntry contact)
        {
            if (contact != null)
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
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            formRefresh();
        }

        private void newRecordButton_Click(object sender, EventArgs e)
        {
            EntryBuilder.mode = EntryBuilder.modeEnum.Contact;
            new NewContactForm().Show();
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
            saveRecord();
            AppController.saveRecords();
            formRefresh();
        }

        private void RecordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RecordList.SelectedItem != null && RecordList.SelectedItem.ToString() != "")
            {
                ContactEntry.currentContact = AppController.GetContact(RecordList.SelectedItem.ToString());
            }
            formRefresh();
            loadFields(ContactEntry.currentContact);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            AppController.loadRecords();
            //schoolSource.DataSource = SchoolEntry.allSchools;
            // GroupList.DataSource = schoolSource;
            //RecordList.DataSource = contactSource;
            formRefresh();
            formRefresh();
        }
        private void updateStatusLabel()
        {
            if (ContactEntry.currentContact != null)
            {
                ContactEntry contact = ContactEntry.currentContact;
                currentRecordDetails.Text = contact.contactName + "(" + contact.contactLogin + "), " + contact.contactPosition + " @ " + contact.contactSchool.schoolScope + ": " + contact.contactEmail + " " + contact.contactPhone1;
                currentRecordDetails.Visible = true;
            }else
            {
                currentRecordDetails.Text = "No Record Selected. Click on a record to view its details";
            }

        }
        private void MainWindowTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contactDeleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you wish to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                ContactEntry.currentContact.Delete();
                formRefresh();
            }
            else
            {

            } 
        }

        private void emailLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + emailField.Text);
        }

        private void currentRecordDetails_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(currentRecordDetails.Text);
        }
    }
}
