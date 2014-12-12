using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperShopApp
{
    class Shop
    {
        public string ShopName { set; get; }
        public string ShopAddress { set; get; }

        public List<Product> ProductList;

        public Shop()
        {
            ProductList = new List<Product>();
        }

        public List<Product> GetProductList()
        {
            return ProductList;
        }

        public string AddProduct(Product productAdd)
        {
            bool isFound = false;
            string msg = "product added";
            foreach (Product aProduct  in ProductList)
            {
                if (aProduct.ProductId == productAdd.ProductId)
                {
                    aProduct.ProductQuantity = productAdd.ProductQuantity;
                   // ProductList.Add(productAdd);
                    isFound = true;
                    msg = "product updated";
                }
            }
            if (!isFound)
            {
                ProductList.Add(productAdd);
            }
            return msg;
        }
    }
}
