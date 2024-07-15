using System;

namespace Smart_Cart
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Smart Cart Application!");
            Console.WriteLine("You can shop at different stores, view your cart, and checkout.");
            Console.WriteLine("Let's get started!\n");


            ShoppingCart cart = new ShoppingCart();
            Shop groceryStore = new GroceryStore();
            Shop clothingStore = new ClothingStore();
            Shop electronicsStore = new ElectronicsStore();

            bool running = true;
            while (running)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. Shop at Electronics Store");
                Console.WriteLine("4. View Cart");
                Console.WriteLine("5. View Random Items");
                Console.WriteLine("6. Checkout and Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nWelcome to the Grocery Store!");
                        Console.WriteLine("Browse through our selection of fresh produce and pantry items.\n");
                        ShopAtStore(groceryStore, cart);
                        break;
                    case "2":
                        Console.WriteLine("\nWelcome to the Clothing Store!");
                        Console.WriteLine("Explore our latest fashion trends and wardrobe essentials.\n");
                        ShopAtStore(clothingStore, cart);
                        break;
                    case "3":
                        Console.WriteLine("\nWelcome to the Electronics Store!");
                        Console.WriteLine("Discover cutting-edge electronics and gadgets.\n");
                        ShopAtStore(electronicsStore, cart);
                        break;
                    case "4":
                        ShoppingCart.ViewItems();
                        Console.WriteLine($"Total Cost: ${ShoppingCart.TotalCost()}");
                        RemoveItemFromCart(cart);
                        break;
                    case "5":
                        Product randomProduct = ProductGenerator.GenerateProduct(); 
                        Console.WriteLine($"Random Product: {randomProduct.Name} - ${randomProduct.Price:F2} - {randomProduct.Category}");
                        Console.WriteLine("Do you want to add this item to your cart? (yes/no)");
                        string addToCartChoice = Console.ReadLine().ToLower();

                        if (addToCartChoice == "yes")
                        {
                            cart.AddItem(randomProduct);
                            Console.WriteLine("Item added to cart.");
                        }
                        else if (addToCartChoice == "no")
                        {
                            Console.WriteLine("Item not added to cart.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Item not added to cart.");
                        }
                        break;
                    case "6":
                        Console.WriteLine($"Total Cost: ${ShoppingCart.TotalCost()}");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ShopAtStore(Shop shop, ShoppingCart cart)
        {
            shop.DisplayProducts();
            Console.WriteLine("Enter the index of the product to add to the cart:");
            if (int.TryParse(Console.ReadLine(), out int productIndex))
            {
                if (productIndex >= 0 && productIndex < shop.AvailableProducts.Count)
                {
                    cart.AddItem(shop.AvailableProducts[productIndex]);
                }
                else
                {
                    Console.WriteLine("Invalid product index. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        static void RemoveItemFromCart(ShoppingCart cart)
        {
            Console.WriteLine("Enter the index of the product to remove from the cart, or 'home' to back home:");
            string input = Console.ReadLine();
            while (input.ToLower() != "home")
            {
                if (int.TryParse(input, out int itemIndex))
                {
                    cart.RemoveItem(itemIndex);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                Console.WriteLine("Enter the index of the product to remove from the cart, or 'done' to finish:");
                input = Console.ReadLine();
            }
        }

        
    }
}
