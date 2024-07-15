using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ElectronicsStore : Shop
    {
        protected override void PopulateProducts()
        {
            availableProducts.Add(new Product("Laptop", 999.99, ProductCategory.Electronics));
            availableProducts.Add(new Product("Smartphone", 799.99, ProductCategory.Electronics));
            availableProducts.Add(new Product("Tablet", 499.99, ProductCategory.Electronics));
            availableProducts.Add(new Product("Smartwatch", 199.99, ProductCategory.Electronics));
            availableProducts.Add(new Product("Headphones", 149.99, ProductCategory.Electronics));
           
        }
    }

}
