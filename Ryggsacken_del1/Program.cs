using System;
using System.Collections.Generic;
namespace Ryggsacken_del1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> fruits = new List<string>();
            bool run = true;
            
            string home()
            {
                Console.WriteLine("Välkommen till ryggsäcken!");
                Console.WriteLine("[1] Lägg till en frukt i ryggsäcken");
                Console.WriteLine("[2] Skriv ut innehållet");
                Console.WriteLine("[3] Rensa innehållet");
                Console.WriteLine("[4] Avsluta");
                Console.Write("Välj: ");

                return Console.ReadLine();
            }
            while (run)
                switch (home())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Lägg i önskad frukt i ryggsäcken:");
                        fruits.Add(Console.ReadLine());
                        break;

                    case "2":
                        Console.Clear();
                        if (fruits.Count == 0)
                        {
                            Console.WriteLine("Ryggsäcken är tom!");
                        }
                        else
                        {
                            Console.WriteLine("Ryggsäcken innehåller:");
                            foreach (string thing in fruits)
                            {
                                Console.WriteLine(thing);
                            }
                        }
                        break;

                    case "3":
                        Console.Clear();
                        fruits.Clear();
                        Console.WriteLine("Ryggsäcken har blivit rensad!");
                        break;

                    case "4":
                        run = false;
                        Console.Clear();
                        Console.WriteLine("Programmet avslutas nu.");
                        break;
                }
        }
    }
}