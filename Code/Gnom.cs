using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    internal class Gnom : Fighter
    {
        public Gnom()
        {
            Blood = 700;
            Attack = 25;
        }
        public override string FighterType
        {
            get
            {
                return "Гном";
            }
        }
        public override int DamageChampion()
        {
            return Attack;
        }
    }
}
