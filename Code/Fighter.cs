using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    internal abstract class Fighter : IFighter
    {
        public bool IsAlive { get; protected set; } = true;
        public int Blood { get; protected set; }
        public int Attack { get; protected set; }
        public abstract string FighterType { get; }

        public void ShowObject()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(FighterType);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Blood: {Blood}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Attack: {Attack}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void ReduceBlood(int amountOfBloodToReduce)
        {
            if ((Blood - amountOfBloodToReduce) <= 0)
            {
                Blood = 0;
                IsAlive = false;
            }
            else
            {
                Blood -= amountOfBloodToReduce;
            }
        }
        public abstract int DamageChampion();

        public void PrintFighterInfo()
        {
            Console.WriteLine($"{FighterType}:");
            ShowObject();
        }

        public void BattleWithGnome()
        {
            Console.WriteLine("Битката с Гном започва!");
            Console.ReadLine();

            Gnom gnome = new Gnom();

            int roundCounter = 0;
            bool boosterApplied = false;

            Console.Clear();
            PrintFighterInfo();
            Console.WriteLine();
            gnome.PrintFighterInfo();
            Console.WriteLine();
            Console.WriteLine("Битката предстои");

            while (IsAlive && gnome.IsAlive)
            {
                roundCounter++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("PRESS ENTER --> ROUND " + roundCounter);
                Console.ForegroundColor = ConsoleColor.White;

                if (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    continue;  // Продължаваме цикъла само ако натиснатият клавиш не е Enter
                }

                Console.Clear();

                int damageToGnome = DamageChampion();
                gnome.ReduceBlood(damageToGnome);

                Console.WriteLine($"{FighterType} атакува Гном за {damageToGnome}.");

                // победа на гнома
                if (!gnome.IsAlive)
                {
                    Console.WriteLine($"Гнома е победен от {FighterType}!");
                    break;
                }

                // Гнома атакува войника
                int damageToSelf = gnome.DamageChampion();
                ReduceBlood(damageToSelf);

                Console.WriteLine($"Гнома атакува {FighterType} за {damageToSelf}.");

                if (!IsAlive)
                {
                    Console.WriteLine($"{FighterType} е убит от Гнома!");
                    break;
                }

                // Текущия статус след всеки
                Console.WriteLine($"Текущ статус:");
                PrintFighterInfo();
                gnome.PrintFighterInfo();

                // Проверка за ефекти след всеки 3 рунда
                if (roundCounter % 3 == 0 && !boosterApplied)
                {
                    ApplyBooster();
                    boosterApplied = true;
                }
                else
                {
                    boosterApplied = false;  // Нулиране на бустер 
                }
            }

            // Покажи победителя и оставащата кръв
            Console.WriteLine("Битката приключи!");
            if (!IsAlive)
            {
                Console.WriteLine($"{FighterType} е победен от Гнома!");
            }
            else
            {
                Console.WriteLine($"Гнома е победен от {FighterType}!");
            }
        }
        private void ApplyBooster()
        {
            Blood += 75;
            Attack += 25;

            Console.WriteLine($"{FighterType} получи бустер за този рунд!");
        }
    }
}
