using System;
using System.Collections.Generic;
using System.Text;

namespace employee_management_system
{
    public class PartTimeEmployee : Employee
    {
        private int hoursWorked;
        private double hourlyRate;

        public PartTimeEmployee(int id, string name, int hours, double rate)
            : base(id, name, 0)
        {
            hoursWorked = hours;
            hourlyRate = rate;
        }

        public override double CalculateSalary()
        {
            return hoursWorked * hourlyRate;
        }
    }

}
