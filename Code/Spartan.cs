using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    internal class Spartan : Fighter
    {
        public Spartan()
        {
            Blood = 300;
            Attack = 60;
        }
        public override string FighterType
        {
            get
            {
                return "Спартанец";
            }
        }
        public override int DamageChampion()
        {
            return Attack;
        }
    }
}
