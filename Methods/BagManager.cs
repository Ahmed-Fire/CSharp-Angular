using System;
namespace Methods
{
    class BagManager
    {
        public void AddIt(Product product)
        {
            Console.WriteLine("Congrats! The item was added : " + product.Name);
        }

        public void AddIt2(string productName, string detail, double price, int stockAmount)
        {
            Console.WriteLine("Congrats. Added it to bag : " + productName);
        }
    }
}
