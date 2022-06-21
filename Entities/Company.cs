using System;
using System.Collections.Generic;
using System.Text;

namespace Mabs01.Entities
{
    internal class Company : Taxpayer
    { 
        public int Employees { get; set; }

        public Company(int employees, string name, double income) : base(name, income)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            if(Employees > 10)
            {
                return Income * 14 / 100;
            }
            else
            {
                return Income * 16 / 100;
            }
        }
    }
}
