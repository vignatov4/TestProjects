using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest.AppHost
{
    public abstract class Employee
    {
        public string Name { get; protected set; }
        public int Id { get; protected set; }
        public float Salary { get; protected set; }

        public Employee(string name, int id, float salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }


        public virtual void CalculateAnnualSalary()
        {
            float annual = Salary * 12;
            Console.WriteLine($"[DEFAULT] Annual salary for {Name}: {annual}");
        }
    }
}
