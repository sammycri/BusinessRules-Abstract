using System;
using System.Collections.Generic;
using System.Text;

namespace Mabs01.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Taxpayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Tax();
    }
}
