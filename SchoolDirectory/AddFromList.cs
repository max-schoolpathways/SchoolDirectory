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
        
        public AddFromList()
        {
            InitializeComponent();
        }

        private void AddFromList_Load(object sender, EventArgs e)
        {
            if(addMode == addModeEnum.Product)
            {
                listSource.DataSource = ProductEntry.allProducts;
            }
            listBox.DataSource = listSource;
            listSource.ResetBindings(false);
            
        }
    }
}
