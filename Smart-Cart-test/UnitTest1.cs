using Smart_Cart;

namespace Smart_Cart_test
{
    public class UnitTest1
    {
        [Fact]
        public void AddingItemTest()
        {
            // Arrange
            var cart = new ShoppingCart();
            var item = new Product("Apple", 1.99, ProductCategory.Food);

            // Act
            cart.AddItem(item);

            // Assert
            Assert.Contains(item, ShoppingCart.items);


        }

        [Fact]
        public void RemovingItemTest()
        {
            // Arrange
            var cart = new ShoppingCart();
            var item = new Product("Apple", 1.99, ProductCategory.Food);

            // Act
            cart.AddItem(item);
            cart.RemoveItem(0);

            var itemscount =ShoppingCart.items.Count;
            // Assert
            Assert.DoesNotContain(item, ShoppingCart.items);


        }

        [Fact]
        public void TotalCostTest()
        {
            // Arrange
            var cart = new ShoppingCart();
            var item1 = new Product("Apple", 1.99, ProductCategory.Food);
            var item2 = new Product("Shirt", 19.99, ProductCategory.Clothing);
            cart.AddItem(item1);
            cart.AddItem(item2);

            // Act
            var totalCost = ShoppingCart.TotalCost();

            // Assert
            Assert.Equal(21.98, totalCost, 2); 
        }
    }
}