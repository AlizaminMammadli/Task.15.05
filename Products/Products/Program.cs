using System.Diagnostics;

namespace Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product1 = new { Id = 123, Name = "Cup", Price = 00, StockCount = 76 };
            var product2 = new { Id = 234, Name = "Spoon", Price = 00, StockCount = 27 };
            var product3 = new { Id = 345, Name = "Frying Pan", Price = 00, StockCount = 4 };
            double numaver = 0;

            var products = new[] { product1, product2, product3 };

            foreach (var product in products)
            {
                numaver += product.Price;
            }

            numaver = numaver / products.Length;

            Console.WriteLine($"The price numerical average is - {numaver} Euro" );
        }
    }
}
