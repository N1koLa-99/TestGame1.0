using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml;

namespace TestGame
{
    internal class Program
    {
        static int count = 1;
      
        static void Main(string[] args)
        {
            Console.WriteLine("Избери си войн....от 1 до 3");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 1-Римлянин \n 2-Викинг \n 3-Спартанец\n");
            Console.ForegroundColor = ConsoleColor.White;

            List<Fighter> worriors = new List<Fighter>();
            CreatFighter(worriors);

            BattleBegan(worriors);

        }
        private static void BattleBegan(List<Fighter> worriors)
        {
            bool battleIsOver = false;

            do
            {
                Console.Clear();
                foreach (Fighter warrior in worriors)
                {
                    Console.WriteLine($"Играч {count} : ");
                    warrior.ShowObject();
                    count++;
                    Console.Clear();
                }
                break;

            }
            while (!battleIsOver);
            {

            }

        }
        private static void CreatFighter(List<Fighter> worriors)
        {
            for (int i = 0; i < 2; i++)
            {
                int chosenNational;
                if (i == 0)
                {
                    Console.Write("Играч 1 въведете число...");
                    chosenNational = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Играч 2 въведете число...");
                    chosenNational = int.Parse(Console.ReadLine());
                }

                switch (chosenNational)
                {
                    case 1:
                        {
                            Console.WriteLine("Ти избра:");
                            Fighter roman = new Roman();
                            roman.ShowObject();
                            worriors.Add(roman);
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Ти избра:");
                            Fighter viking = new Viking();
                            viking.ShowObject();
                            worriors.Add(viking);
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Ти избра:");
                            Fighter spartan = new Spartan();
                            spartan.ShowObject();
                            worriors.Add(spartan);
                            break;
                        }
                }
            }
        }
    }
}
