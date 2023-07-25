using System;

namespace Znaki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisz coś");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Nie wpisałeś nic. -_-");
            }
            else
            {
                int liczbaZnakow = input.Length;
                Console.WriteLine("Liczba znaków w tym wierszu: " + liczbaZnakow);
                Dictionary<char, int> wystapieniaZnakow = new Dictionary<char, int>();

                foreach (char znak in input)
                {
                    if (wystapieniaZnakow.ContainsKey(znak))
                    {
                        wystapieniaZnakow[znak]++;
                    }
                    else
                    {
                        wystapieniaZnakow[znak] = 1;
                    }
                }
                Console.WriteLine("Liczba wystąpień poszczególnych znaków:");

                foreach (var kvp in wystapieniaZnakow)
                {
                    Console.WriteLine("'" + kvp.Key + "': " + kvp.Value);
                }
            }
        }
    }
}
