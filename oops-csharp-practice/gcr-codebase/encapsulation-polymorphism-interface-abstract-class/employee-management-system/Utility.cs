using System;
using System.Collections.Generic;
using System.Text;

namespace employee_management_system
{
    public class Utility
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            Employee e1 = new FullTimeEmployee(101, "Amit", 50000);
            e1.AssignDepartment("IT");

            Employee e2 = new PartTimeEmployee(102, "Ravi", 80, 300);
            e2.AssignDepartment("Support");

            employees.Add(e1);
            employees.Add(e2);

            // Polymorphism: Employee reference
            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();
            }
        }
    }
}
