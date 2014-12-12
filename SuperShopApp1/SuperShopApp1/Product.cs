using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp1
{
    class Product
    {
        public string ProductId { set; get; }
        public int ProductQuantity { set; get; }

        public Product(string productId, int productQuantity)
        {
            ProductId = productId;
            ProductQuantity = productQuantity;
        }
    }
}
