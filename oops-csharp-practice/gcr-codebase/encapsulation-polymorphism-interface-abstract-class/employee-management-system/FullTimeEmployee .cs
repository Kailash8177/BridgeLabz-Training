using System;
using System.Collections.Generic;
using System.Text;

namespace employee_management_system
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id, string name, double salary)
            : base(id, name, salary)
        {
        }

        public override double CalculateSalary()
        {
            return baseSalary; // fixed monthly salary
        }
    }

}
