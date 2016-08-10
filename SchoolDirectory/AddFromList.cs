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
    public partial class AddFromList : Form
    {
        public enum addModeEnum {Product};
        public addModeEnum addMode;
        private BindingSource listSource = new BindingSource();
        public Form parentForm;
        
        public AddFromList()
        {
            InitializeComponent();
        }

        private void AddFromList_Load(object sender, EventArgs e)
        {
            if(addMode == addModeEnum.Product)
            {
                listSource.DataSource = ProductEntry.allProducts;
                listBox.DisplayMember = "name";
            }
            listBox.DataSource = listSource;
            listSource.ResetBindings(false);
            
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox.SelectedItem;
            if(addMode == addModeEnum.Product)
            {
                Type parentType = parentForm.GetType();
                if (parentType == typeof(GroupInfo))
                {
                    var newEntry = new ExperienceEntry(selectedItem as ProductEntry,SchoolEntry.currentEntry);
                    ExperienceEntry entryCheck = null;
                    foreach(ExperienceEntry product in SchoolEntry.currentEntry.products)
                    {
                        if(newEntry.productName == product.productName)
                        {
                            entryCheck = product;
                        }
                    }
                    if (entryCheck == null)
                    {
                        SchoolEntry.currentEntry.products.Add(newEntry);
                        var entryForm = parentForm as GroupInfo;
                        entryForm.formRefresh();
                    }
                    else
                    {
                        MessageBox.Show("" + SchoolEntry.currentEntry.schoolName + " is already using " + newEntry.productName + "! Nothing has been done", "Duplicate Detected", MessageBoxButtons.OK);
                        ActiveForm.Close();
                    }
                }
            }
            ActiveForm.Close();
        }
    }
}
