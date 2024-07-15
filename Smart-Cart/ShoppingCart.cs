using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ShoppingCart
    {
         public static List<Product> items = new List<Product>();

        public  void AddItem(Product item)
        {
            items.Add(item);
            Console.WriteLine($"The Item added Successfully ");
        }


        public void RemoveItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                Console.WriteLine($"{items[index].Name} removed from the cart.");
                items.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index. No item removed.");
            }
        }

        public static void ViewItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
            }
            else
            {
                Console.WriteLine("Items in your cart:");
                for (int i = 0; i < items.Count; i++)
                {
                    var item = items[i];
                    Console.WriteLine($"{i}. {item.Name} - ${item.Price:F2} - {item.Category}");
                }
            }
        }

        public static double TotalCost()
        {
            double total = 0;
            foreach (Product i in items)
            {
                total += i.Price;
            }

            return total;
        }
    }
}
