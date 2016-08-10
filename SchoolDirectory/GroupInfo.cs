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
        private bool productActiveStatus = false;
        public GroupInfo()
        {
            InitializeComponent();
        }

        private void GroupInfo_Load(object sender, EventArgs e)
        {
            if(EntryBuilder.mode == EntryBuilder.modeEnum.Existing)
            {
                formRefresh();
                
            }
            else
            {
                addProductButton.Enabled = false;
                
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
              
                SchoolEntry newSchool = new SchoolEntry(scopeNameBox.Text, groupNameBox.Text);
                if (!SchoolEntry.allSchools.Contains(newSchool))
                {
                    SchoolEntry.allSchools.Add(newSchool);
                }
                AppController.saveRecords();
                MainWindow.Form.formRefresh();
                ActiveForm.Close();
            }
            if(ExperienceEntry.currentExperienceEntry != null)
            {
                saveExperience();
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

        private void addProductButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddFromList();
            newForm.addMode = AddFromList.addModeEnum.Product;
            newForm.parentForm = this;
            newForm.Show();
        }

        public void formRefresh()
        {
            addProductButton.Enabled = true;
            groupNameBox.Text = SchoolEntry.currentEntry.schoolName;
            scopeNameBox.Text = SchoolEntry.currentEntry.schoolScope;
            noteTextbox.Text = SchoolEntry.currentEntry.schoolNotes;
            productSource.DataSource = SchoolEntry.currentEntry.products;
            productsList.DataSource = productSource;
            productSource.ResetBindings(true);
            productsList.DisplayMember = "productName";
            if(SchoolEntry.currentEntry.products.Count > 0)
            {
                loadExperience(SchoolEntry.currentEntry.products[0]);
            }
            if (SchoolEntry.currentEntry.director != null)
            {
                directorName.Text = SchoolEntry.currentEntry.director.contactName;
            }
            if (SchoolEntry.currentEntry.primaryContact != null)
            {
                primaryContactName.Text = SchoolEntry.currentEntry.primaryContact.contactName;
            }
        }
        void loadExperience(ExperienceEntry exp)
        {
            ExperienceEntry.currentExperienceEntry = exp;
            if (exp.isActive)
            {
                activeRadioFalse.Checked = false;
                activeRadioTrue.Checked = true;
            }
            else
            {
                activeRadioFalse.Checked = true;
                activeRadioTrue.Checked = false;
            }
            purchaseDateTextBox.Text = exp.purchaseDate;
            cancelDateTextBox.Text = exp.cancelDate;
            productCostTextBox.Text = exp.cost;
            experienceNotesTextBox.Text = exp.notes;
        }
        void saveExperience()
        {
            if (ExperienceEntry.currentExperienceEntry != null)
            {
                if (activeRadioFalse.Checked)
                {
                    ExperienceEntry.currentExperienceEntry.isActive = false;
                }
                else
                {
                    ExperienceEntry.currentExperienceEntry.isActive = true;
                }
                ExperienceEntry.currentExperienceEntry.purchaseDate = purchaseDateTextBox.Text;
                ExperienceEntry.currentExperienceEntry.cancelDate = cancelDateTextBox.Text;
                ExperienceEntry.currentExperienceEntry.cost = productCostTextBox.Text;
                ExperienceEntry.currentExperienceEntry.notes = experienceNotesTextBox.Text;
            }
        }
        private void removeProductButton_Click(object sender, EventArgs e)
        {
            formRefresh();
        }

        private void productsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //saveExperience();
            loadExperience(productsList.SelectedItem as ExperienceEntry);
        }

        private void saveDetailsButton_Click(object sender, EventArgs e)
        {
            saveExperience();
        }
    }
}
