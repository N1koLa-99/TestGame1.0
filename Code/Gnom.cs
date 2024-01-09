using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    internal class Gnoms : Fighter
    {
        public Gnoms()
        {
            Blood = 300;
            Attack = 15;
        }
        public override string FighterType
        {
            get
            {
                return "Гном";
            }
        }
    }
}
