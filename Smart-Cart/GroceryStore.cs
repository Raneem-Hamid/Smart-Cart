using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class GroceryStore : Shop
    {
        protected override void PopulateProducts()
        {
            availableProducts.Add(new Product("Apple", 1.99, ProductCategory.Food));
            availableProducts.Add(new Product("Banana", 0.99, ProductCategory.Food));
            availableProducts.Add(new Product("Bread", 2.49, ProductCategory.Food));
            availableProducts.Add(new Product("Milk", 1.49, ProductCategory.Food));
            availableProducts.Add(new Product("Cheese", 3.99, ProductCategory.Food));
            
        }
    }
}
