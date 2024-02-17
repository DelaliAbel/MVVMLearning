using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLearning.Models
{
    public class ProductModel : BaseModel
    {
        public string ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductSupplier { get; set; }
        public string ProductDateExp { get; set; }

        public ProductModel()
        {

        }

        public ProductModel(string price, string description, int quantity, string supplier, string dateExp)
        {
            this.ProductPrice = price;
            //this.ProductDescription = description;
            this.ProductQuantity = quantity;
            this.ProductSupplier = supplier;
            this.ProductDateExp = dateExp;
        }

    }
}
