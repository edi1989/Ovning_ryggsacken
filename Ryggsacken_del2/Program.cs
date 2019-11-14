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
                Console.Clear();
                Console.WriteLine("Välkommen till ryggsäcken!");
                Console.WriteLine("[1] Lägg till en frukt i ryggsäcken");
                Console.WriteLine("[2] Skriv ut innehållet");
                Console.WriteLine("[3] Radera senast tillagda frukt");
                Console.WriteLine("[4] Rensa innehållet");
                Console.WriteLine("[5] Avsluta");
                Console.Write("Välj: ");
                return Console.ReadLine();
            }
            while (run)
                switch (home())
                {
                    case "1":
                        if (fruits.Count == 6)
                        {
                            Console.WriteLine("Ryggsäcken är full!");
                        }
                        else
                        {
                            Console.WriteLine("Lägg i önskad frukt i ryggsäcken:");
                            fruits.Add(Console.ReadLine());
                        }
                        break;


                    case "2":
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
                        Console.Write("Tryck en tagent för att fortsätta: ");
                        Console.ReadKey();
                        break;

                    case "3":
                        if (fruits.Count != 0)
                        {
                            fruits.RemoveAt(fruits.Count - 1);
                            Console.WriteLine("Senast tillagda frukt borttagen!");
                        }
                        else
                        {
                            Console.WriteLine("Ryggsäcken är tom!");
                        }

                        break;

                    case "4":
                        fruits.Clear();
                        Console.WriteLine("Ryggsäcken har blivit rensad!");
                        break;

                    case "5":
                        run = false;
                        Console.Clear();
                        Console.WriteLine("Programmet avslutas nu.");
                        break;
                }
        }
    }
}