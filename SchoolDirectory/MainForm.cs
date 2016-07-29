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
        public MainWindow()
        {
            InitializeComponent();
            Form = this;
        }

        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            SchoolEntry.currentEntry = SchoolEntry.allSchools[GroupList.SelectedIndex];
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
            RecordList.Items.Clear();
            
            schoolNames.Clear();
            

            foreach(var school in SchoolEntry.allSchools)
            {
                schoolNames.Add(school.schoolScope);
            }

            GroupList.DataSource = schoolNames;
            buildContactList();
        }

        private void buildContactList()
        {
            contactNames.Clear();
            if(SchoolEntry.currentEntry != null)
            foreach(var contact in SchoolEntry.currentEntry.schoolContacts)
            {
                contactNames.Add(contact.contactName);
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
    }
}
