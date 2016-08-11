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
    public partial class ProductInfo : Form
    {
        private BindingSource userSource = new BindingSource();
        private BindingSource productSource = new BindingSource();
        public enum entryModeEnum {New,Existing}
        public entryModeEnum entryMode;
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            if(entryMode == entryModeEnum.Existing)
            {
                productListGroupBox.Visible = true;
                loadProduct();
            }else
            {
                productListGroupBox.Visible = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveProduct();
            if (entryMode == entryModeEnum.New)
            {
                ActiveForm.Close();
            }
        }
        void saveProduct()
        {
            ProductEntry savedEntry;
            if (entryMode == entryModeEnum.Existing)
            {
                savedEntry = ProductEntry.currentProduct;
            }
            else
            {
                savedEntry = new ProductEntry(nameTextBox.Text);
            }
            savedEntry.name = nameTextBox.Text;
            savedEntry.company = companyTextBox.Text;
            savedEntry.websiteURL = websiteTextBox.Text;
            savedEntry.cost = costTextBox.Text;
            savedEntry.description = descriptionTextBox.Text;
            if (!ProductEntry.allProducts.Contains(savedEntry))
            {
                ProductEntry.allProducts.Add(savedEntry);
            }
            AppController.saveRecords();
        }
        void loadProduct()
        {
            nameTextBox.Text = ProductEntry.currentProduct.name;
            companyTextBox.Text = ProductEntry.currentProduct.company;
            websiteTextBox.Text = ProductEntry.currentProduct.websiteURL;
            costTextBox.Text = ProductEntry.currentProduct.cost;
            descriptionTextBox.Text = ProductEntry.currentProduct.description;
            userSource.DataSource = SchoolEntry.GetUsers(ProductEntry.currentProduct);
            usersListBox.DataSource = userSource;
            usersListBox.DisplayMember = "schoolScope";
            userSource.ResetBindings(false);
            productSource.DataSource = ProductEntry.allProducts;
            productListBox.DataSource = productSource;
            productListBox.DisplayMember = "name";
            productSource.ResetBindings(false);
        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductEntry.currentProduct = productListBox.SelectedItem as ProductEntry;
            loadProduct();
        }
    }
}
