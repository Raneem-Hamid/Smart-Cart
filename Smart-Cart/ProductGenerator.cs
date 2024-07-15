using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ProductGenerator
    {
        

        public static  Product GenerateProduct()
        {
            Random random = new Random();
        Dictionary<string, (double MinPrice, double MaxPrice, ProductCategory Category)> products;
        random = new Random();
            products = new Dictionary<string, (double, double, ProductCategory)>
        {
            { "Apple", (0.5, 2.0, ProductCategory.Food) },
            { "Banana", (0.3, 1.5, ProductCategory.Food) },
            { "Shirt", (10.0, 50.0, ProductCategory.Clothing) },
            { "Pants", (20.0, 60.0, ProductCategory.Clothing) },
            { "Laptop", (500.0, 1500.0, ProductCategory.Electronics) },
            { "Phone", (300.0, 1000.0, ProductCategory.Electronics) }
        };

            List<string> productsKey = products.Keys.ToList();
            int randomIndex = random.Next(productsKey.Count);
            string name = productsKey[randomIndex];
            var (minPrice, maxPrice, category) = products[name];
            double price = (double)random.NextDouble() * (maxPrice - minPrice) + minPrice;

            return new Product(name, price, category);
        }
    }

 
        
}
