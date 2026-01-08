using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;

        private static Random random = new Random();
        private const int WAGE_PER_HOUR = 20;
        private const int FULL_DAY_HOURS = 8;
        private const int PART_TIME_HOURS = 8;
        private const int WORKING_DAYS = 20;
        private const int MAX_WORKING_DAYS = 20;
        private const int MAX_WORKING_HOURS = 100;
        public Employee AddEmployee()
        {
            employee = new Employee();

            Console.WriteLine("Enter Employee ID: ");
            employee.EmployeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            employee.EmployeeName = Console.ReadLine();


            employee.IsPresent = random.Next(2) == 1;
            employee.IsPartTime = random.Next(2) == 1;

            return employee;
        }

        public void DisplayEmployeeDetails(Employee employees)
        {
            Console.WriteLine($"EmployeeName : {employee.EmployeeName} ,   EmpoyeeId : {employee.EmployeeId} , Is Employee Present : {employee.IsPresent}, is Employee PartTime : {employee.IsPartTime}");
        }

        //UC-1
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

        // UC-2
        public void CalculateDailyWage(Employee employee)
        {
            if (employee.IsPresent)
                employee.DailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
            else
                employee.DailyWage = 0;

            Console.WriteLine($"Daily Wage : {employee.DailyWage}");
        }

        // UC-3

        public void CalculatePartTimeWage(Employee employee)
        {
            if (employee.IsPresent && employee.IsPartTime)
                employee.PartTimeWage = WAGE_PER_HOUR * PART_TIME_HOURS;
            else
                employee.PartTimeWage = 0;
            Console.WriteLine($"Part-Time Wage : {employee.PartTimeWage}");
        }

        //UC-5

        public void CalculateMonthlyWage(Employee employee)
        {
            if (employee.IsPresent)
                employee.MonthlyWage = WAGE_PER_HOUR * FULL_DAY_HOURS * WORKING_DAYS;
            else
                employee.MonthlyWage = 0;
            Console.WriteLine($"Monthly Wage : {employee.MonthlyWage}");
        }

        //UC-6
        public void CalculateWageTillCondition(Employee employee)
        {
            employee.TotalWorkingDays = 0;
            employee.TotalWorkingHours = 0;
            employee.MonthlyWage = 0;

            while (employee.TotalWorkingDays < MAX_WORKING_DAYS &&
                   employee.TotalWorkingHours < MAX_WORKING_HOURS)
            {
                employee.TotalWorkingDays++;

                // Random attendance
                bool isPresent = random.Next(2) == 1;

                if (isPresent)
                {
                    employee.TotalWorkingHours += FULL_DAY_HOURS;
                    employee.MonthlyWage += FULL_DAY_HOURS * WAGE_PER_HOUR;
                }
            }

            Console.WriteLine("UC-5 Result:");
            Console.WriteLine($"Total Working Days  : {employee.TotalWorkingDays}");
            Console.WriteLine($"Total Working Hours : {employee.TotalWorkingHours}");
            Console.WriteLine($"Total Monthly Wage  : {employee.MonthlyWage}");
        }


    }
}
