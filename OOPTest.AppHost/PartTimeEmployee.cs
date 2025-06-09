using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest.AppHost
{
    public class PartTimeEmployee: Employee
    {
        public PartTimeEmployee(string name, int id, float salary)
        : base(name, id, salary) { }

        public override void CalculateAnnualSalary()
        {
            base.CalculateAnnualSalary();
        }


    }
}
