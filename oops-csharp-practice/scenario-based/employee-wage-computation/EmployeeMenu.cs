using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    public sealed class EmployeeMenu
    {

        private IEmployee employeeUtility;
        private Employee currentEmployee;


        public  EmployeeMenu() 
        {
            employeeUtility = new EmployeeUtilityImpl();
            ShowMenu();
        }

        private void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nEmployee Menu");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display Employee");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        currentEmployee = employeeUtility.AddEmployee();
                        Console.WriteLine("Employee added successfully.");
                        break;
                    case 2:
                        if (currentEmployee != null)
                        {
                            employeeUtility.DisplayEmployeeDetails(currentEmployee);
                        }
                        else
                        {
                            Console.WriteLine("No employee data available. Please add an employee first.");
                        }
                        break;
                    case 3:
                        if (currentEmployee != null)
                            employeeUtility.CheckAttendance(currentEmployee);
                        else
                            Console.WriteLine("No employee added yet");
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
