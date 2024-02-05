using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    internal class Roman : Fighter
    {
        public Roman()
        {
            Blood = 280;
            Attack = 70;
        }
        public override string FighterType
        {
            get
            {
                return "Римлянин";
            }
        }
        public override int DamageChampion()
        {
            return Attack;
        }
    }
}
