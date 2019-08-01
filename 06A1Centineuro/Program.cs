using System;

namespace _06A1Centineuro
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int eur, cent;

            Console.Write("Centbetrag ");
            input = int.Parse(Console.ReadLine());

            eur = input / 100;
            cent = input % 100;

            Console.WriteLine("Das macht {0} Euro und {1} Cent", eur, cent);

        }
    }
}
