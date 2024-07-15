using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ClothingStore : Shop
    {
        protected override void PopulateProducts()
        {
            availableProducts.Add(new Product("Shirt", 19.99, ProductCategory.Clothing));
            availableProducts.Add(new Product("Pants", 29.99, ProductCategory.Clothing));
            availableProducts.Add(new Product("Jacket", 49.99, ProductCategory.Clothing));
            availableProducts.Add(new Product("Shoes", 39.99, ProductCategory.Clothing));
            availableProducts.Add(new Product("Hat", 14.99, ProductCategory.Clothing));
            
        }
    }

}
