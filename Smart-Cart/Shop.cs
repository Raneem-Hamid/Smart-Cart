using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public abstract class Shop
    {
        protected readonly List<Product> availableProducts;

        public List<Product> AvailableProducts => availableProducts;

        public Shop()
        {
            availableProducts = new List<Product>();
            PopulateProducts();
        }

        protected abstract void PopulateProducts();

        public void DisplayProducts()
        {
            for (int i = 0; i < availableProducts.Count; i++)
            {
                var product = availableProducts[i];
                Console.WriteLine($"{i}. {product.Name} - ${product.Price:F2} - {product.Category}");
            }
        }

        public void AddProductToCart(int productIndex, ShoppingCart cart)
        {
            if (productIndex >= 0 && productIndex < availableProducts.Count)
            {
                cart.AddItem(availableProducts[productIndex]);
            }
            else
            {
                Console.WriteLine("Invalid product index. Please try again.");
            }
        }
    }
}
