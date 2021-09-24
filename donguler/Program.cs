using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "C#";
            string kurs2 = "JAVA";
            string kurs3 = "React";

            string[] kurslar = new string[] {"C#", "JAVA", "React","C++","VUE"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Footer");
        }
    }
}
