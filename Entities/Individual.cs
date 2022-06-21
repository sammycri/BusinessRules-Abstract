using System;
using System.Collections.Generic;
using System.Text;

namespace Mabs01.Entities
{
    internal class Individual : Taxpayer
    {
        public double Health { get; set; }

        public Individual(double health, string name, double income) : base(name, income)
        {
            Health = health;
        }

        public override double Tax()
        {          

            if(Income < 20000.00)
            {
                return (Income * 15 / 100) - (Health * 50 / 100);
            }
            else
            {
                return (Income * 25 / 100) - (Health * 50 / 100);
            }
        }

    }
}
