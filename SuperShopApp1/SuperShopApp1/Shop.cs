using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopApp1
{
    class Shop
    {
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public Dictionary<string,Product> Products { set; get; }
        public Shop(string shopName, string shopAddress)
        {
            ShopName = shopName;
            ShopAddress = shopAddress;
            Products =new Dictionary<string, Product>();
            MessageBox.Show("Shop Details is Added.");
        }
        public string AddProduct(Product aProduct )
        {
                if (Products.ContainsKey(aProduct.ProductId))
                {
                    Products[aProduct.ProductId].ProductQuantity += aProduct.ProductQuantity;
                    return "Product Quantity is added";
                }
                Products.Add(aProduct.ProductId, aProduct);
                return "Item is added"; 
        }
    }
}
