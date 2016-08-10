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
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            if(EntryBuilder.mode == EntryBuilder.modeEnum.Existing)
            {
                productListGroupBox.Visible = true;
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

            }else
            {
                productListGroupBox.Visible = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveProduct();
            ActiveForm.Close();
        }
        void saveProduct()
        {
            ProductEntry savedEntry;
            if (EntryBuilder.mode == EntryBuilder.modeEnum.Existing)
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
    }
}
