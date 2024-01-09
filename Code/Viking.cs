using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    internal class Viking : Fighter
    {
        public Viking()
        {
            Blood = 350;
            Attack = 58;
        }
        public override string FighterType
        {
            get
            {
                return "Викинг";
            }
        }
    }
}
