using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperShopApp
{
    class Product
    {
        public string ProductId { set; get; }
        public string ProductQuantity { set; get; }

        public Product(string productId,string productQuantity)
        {
            ProductId = productId;
            ProductQuantity = productQuantity;
        }
    }
}
