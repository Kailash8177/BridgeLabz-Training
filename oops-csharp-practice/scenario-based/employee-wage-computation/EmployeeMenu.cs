using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    public sealed class EmployeeMenu
    {

        private IEmployee employeeUtility;
        private Employee currentEmployee;


        public EmployeeMenu()
        {
            employeeUtility = new EmployeeUtilityImpl();
            ShowMenu();
        }

        private void ShowMenu()
        {
            //UC-4
            while (true)
            {
                Console.WriteLine("\nEmployee Menu");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display Employee");
                Console.WriteLine("3. Check Attendance");
                Console.WriteLine("4. Calculate Daily Wage");
                Console.WriteLine("5. Calculate Part-Time Wage");
                Console.WriteLine("6. Calculate Monthly Wage");
                Console.WriteLine("7. Exit");

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
                        if (currentEmployee != null)
                            employeeUtility.CalculateDailyWage(currentEmployee);
                        else
                            Console.WriteLine("No employee added yet");
                        break;

                    case 5:
                        if (currentEmployee != null)
                            employeeUtility.CalculatePartTimeWage(currentEmployee);
                        else
                            Console.WriteLine("No employee added yet");
                        break;

                    case 6:
                        if (currentEmployee != null)
                            employeeUtility.CalculateMonthlyWage(currentEmployee);
                        else
                            Console.WriteLine("No employee added yet");
                        break;

                    case 7:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
