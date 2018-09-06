using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productID)
        {
            this.ProductID = productID;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductID { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }


        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the Product Data.
        /// </summary>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

    }
}
