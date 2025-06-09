using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest.AppHost
{
    public class FullTimeEmployee: Employee
    {

        public FullTimeEmployee(string name, int id, float salary)
         : base(name, id, salary) { }

        public override void CalculateAnnualSalary()
        {
            float bonus = 1000;
            float annual = (Salary * 12) + bonus;
            Console.WriteLine($"Annual salary for {Name} (ID: {Id}): {annual} + bonus");
        }
    }
}
