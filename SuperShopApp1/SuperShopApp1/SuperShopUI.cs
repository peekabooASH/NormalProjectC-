using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopApp1
{
    public partial class SuperShopUI : Form
    {
        public SuperShopUI()
        {
            InitializeComponent();
        }

        Shop ashop;
        Product aProduct;
        string msg,msg2;
        private void saveButton_Click(object sender, EventArgs e)
        {
            ashop=new Shop(shopNameTextBox.Text,shopAddressTextBox.Text);
            shopNameTextBox.Text = "";
            shopAddressTextBox.Text = "";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
           string msg1 = "";
           msg2 = "";
           msg1="Shop name\tShop Address\n" +
                            ashop.ShopName + "\t\t" + ashop.ShopAddress + 
                            "\nProduct Id  \t Product Quantity\n" ;
            foreach (KeyValuePair<string, Product> Products in ashop.Products )
            {
                 msg2+= Products.Value.ProductId+"\t\t"+Products.Value.ProductQuantity+"\n";
            }
           MessageBox.Show(msg1+msg2);
           
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            aProduct = new Product(itemIdTextBox.Text, Convert.ToInt32(quantityTextBox.Text));
            string msg = ashop.AddProduct(aProduct);
            MessageBox.Show(msg);
            itemIdTextBox.Text = "";
            quantityTextBox.Text="";
        }
    }
}
