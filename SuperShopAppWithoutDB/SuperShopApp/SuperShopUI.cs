using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperShopApp
{
    public partial class SuperShopUI : Form
    {
        private Shop aShop;

        public SuperShopUI()
        {
            InitializeComponent();
        }

        private void saveShopInfoButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop();
            aShop.ShopName = nameTextBox.Text;
            aShop.ShopAddress = addressTextBox.Text;
            MessageBox.Show("shop created");
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product(productIDTextBox.Text,quantityTextBox.Text);
            string msg = aShop.AddProduct(aProduct);
            MessageBox.Show(msg);

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string msg = "product Id\tQuantity\n";
            foreach (Product index in aShop.GetProductList())
            {
                msg += index.ProductId + "\t" +  index.ProductQuantity + "\n";
            }
            MessageBox.Show(msg);

        }
    }
}
