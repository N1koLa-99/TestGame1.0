using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    internal abstract class Fighter
    {
        public bool IsAlive { get; protected set; } = true;
        public int Blood { get; protected set; }
        public int Attack { get; protected set; }
        public abstract string FighterType { get; }

        public  void ShowObject()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( FighterType);
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
    }
}
