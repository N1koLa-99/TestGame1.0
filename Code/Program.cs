using System;
using System.Collections.Generic;

namespace TestGame
{
    internal class Program
    {
        static List<Fighter> warriors;

        private static void Main(string[] args)
        {
            Console.WriteLine("Избери си войн....от 1 до 3");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 1-Римлянин \n 2-Викинг \n 3-Спартанец\n");
            Console.ForegroundColor = ConsoleColor.White;

            warriors = new List<Fighter>();

            int chosenNational;
            bool currentChoice = true;
            Fighter chosenFighter = null;

            while (currentChoice)
            {
                Console.Write("Въведете число за избор на герой: ");
                chosenNational = int.Parse(Console.ReadLine());
                try
                {
                    chosenFighter = GetFighterByNational(chosenNational);
                    Console.WriteLine("Ти избра:");
                    chosenFighter.ShowObject();
                    warriors.Add(chosenFighter);
                    currentChoice = false;
                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Грешка: {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if (chosenFighter != null)
            {
                Fighter player1 = warriors[0];
                player1.BattleWithGnome();
            }
        }

        private static Fighter GetFighterByNational(int chosenNational)
        {
            return chosenNational switch
            {
                1 => new Roman(),
                2 => new Viking(),
                3 => new Spartan(),
                _ => throw new ArgumentException("Невалиден избор за воин, число требва да е в диапазона (от 1 до 3)"),
            };
        }
    }
}
