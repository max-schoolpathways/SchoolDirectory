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
        public BindingSource schoolSource = new BindingSource();
        public BindingSource contactSource = new BindingSource();
        public MainWindow()
        {
            InitializeComponent();
            Form = this; 
        }

        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {

            SchoolEntry.currentEntry = GroupList.SelectedItem as SchoolEntry;
            ContactEntry.currentContact = null;
            RecordList.ClearSelected();
            clearFields();
            formRefresh();
        }

        private void newGroupButton_Click(object sender, EventArgs e)
        {
            EntryBuilder.mode = EntryBuilder.modeEnum.New;
            new GroupInfo().Show();
        }
        public void formRefresh()
        {
            schoolSource.DataSource = SchoolEntry.allSchools;
            GroupList.DataSource = schoolSource;
            GroupList.DisplayMember = "schoolScope";
            schoolSource.ResetBindings(true);
            if (SchoolEntry.currentEntry != null)
            {
                contactSource.DataSource = SchoolEntry.currentEntry.schoolContacts;
                RecordList.DataSource = contactSource;
                RecordList.DisplayMember = "contactLogin";
                //contactSource.ResetBindings(true);
            }
            contactSource.ResetBindings(false);
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
            isDirectorCheckbox.Checked = false;
            isPrimaryContactCheckbox.Checked = false;
        }
        void loadFields(ContactEntry contact)
        {
            clearFields();
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
                if(contact.contactSchool.director == contact)
                {
                    isDirectorCheckbox.Checked = true;
                }
                if(contact.contactSchool.primaryContact == contact)
                {
                    isPrimaryContactCheckbox.Checked = true;
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            formRefresh();
        }

        private void newRecordButton_Click(object sender, EventArgs e)
        {
            new NewContactForm().Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveRecord();
        }
        void saveRecord()
        {
            if (ContactEntry.currentContact != null)
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
            else
            {
                MessageBox.Show("No entry selected!", "No Entry", MessageBoxButtons.OK);
            }

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
            if (isDirectorCheckbox.Checked)
            {
                ContactEntry.currentContact.contactSchool.director = ContactEntry.currentContact;
            }
            if (isPrimaryContactCheckbox.Checked)
            {
                ContactEntry.currentContact.contactSchool.primaryContact = ContactEntry.currentContact;
            }
        }

        private void RecordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RecordList.SelectedItem != null && RecordList.SelectedItem.ToString() != "")
            {
                ContactEntry.currentContact = RecordList.SelectedItem as ContactEntry;
            }
            formRefresh();
            loadFields(ContactEntry.currentContact);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            AppController.loadRecords();
            
            //formRefresh();
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
            if (ContactEntry.currentContact != null)
            {
                var confirmResult = MessageBox.Show("Are you sure you wish to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    ContactEntry.currentContact.Delete();
                    clearFields();
                    formRefresh();
                }
            }
            else
            {
                MessageBox.Show("No active record!", "Warning", MessageBoxButtons.OK);
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

        private void GroupList_DoubleClick(object sender, EventArgs e)
        {
            EntryBuilder.mode = EntryBuilder.modeEnum.Existing;
            new GroupInfo().Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryBuilder.mode = EntryBuilder.modeEnum.New;
            new ProductInfo().Show();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryBuilder.mode = EntryBuilder.modeEnum.Existing;
            ProductEntry.currentProduct = ProductEntry.allProducts[0];
            new ProductInfo().Show();
        }
    }
}
