using System;

namespace kampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safe
            string categories = "category";
            int orenciSayisi = 10000;
            double faizOrani = 1.45;
            bool isSigned = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }

            if (isSigned == true)
            {
                Console.WriteLine("Setting Button");
            }
            else
            {
                Console.WriteLine("Sign Button");
            }

            Console.WriteLine(categories);
        }
    }
}
