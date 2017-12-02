using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRPG.Objects.CharacterClasses
{
    class Class
    {
        protected int Constitution { get; set; }
        protected int Strength { get; set; }
        protected int Agility { get; set; }
        protected int Intellect { get; set; }

        protected Class()
        {
            
        }

        protected Class(int constitution, int strength, int agility, int intellect)
        {
            Constitution = constitution;
            Strength = strength;
            Agility = agility;
            Intellect = intellect;
        }
    }
}
