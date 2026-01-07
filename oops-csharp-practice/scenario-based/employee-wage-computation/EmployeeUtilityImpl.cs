using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;

        private static Random random = new Random();

        public Employee AddEmployee() 
        {
            employee = new Employee();

            Console.WriteLine("Enter Employee ID: ");
            employee.EmployeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            employee.EmployeeName = Console.ReadLine();


            employee.IsPresent = random.Next(2) == 1;
            return employee;
        }

        public void DisplayEmployeeDetails(Employee employees)
        {
           Console.WriteLine($"EmployeeName : {employee.EmployeeName} ,   EmpoyeeId : {employee.EmployeeId} , Employee attandance {employee.IsPresent}");
        }


        public void CheckAttendance(Employee employee)
        {
            if (employee.IsPresent)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
        }

    }
}
