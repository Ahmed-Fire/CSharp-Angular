using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Apple";
            double price = 5;
            string detail = "Best Apple";

            string[] fruits = new string[] { };

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 5;
            product1.Detail = "Best Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 15;
            product2.Detail = "Delicious Watermelon";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Detail);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("------------METHODS-----------");

            BagManager bagManager = new BagManager();
            //instance
            //encapsulation

            bagManager.AddIt(product1);
            bagManager.AddIt(product2);

            bagManager.AddIt2("Melon", "Delicious", 12, 10);
            bagManager.AddIt2("Watermelon", "Delicious", 15, 9);
            bagManager.AddIt2("Apple", "Delicious", 19, 8);
        }
    }
}
