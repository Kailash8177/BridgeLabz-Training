using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    /// <summary>
    /// Employee Wage Computation Program
    /// ---------------------------------_unpack
    /// This program is developed to understand and implement multiple
    /// use cases (UCs) using Object-Oriented Programming concepts in C#.
    /// 
    /// UC-1: Employee Attendance
    /// - Employee attendance is checked using the Random class.
    /// - Random value decides whether the employee is Present or Absent.
    /// 
    /// UC-2: Daily Employee Wage Calculation
    /// - Wage per hour is assumed as 20.
    /// - Full day working hours are assumed as 8.
    /// - Daily wage is calculated only if the employee is present.
    /// 
    /// UC-3: Part-Time Employee Wage
    /// - Employee can be part-time or full-time.
    /// - Part-time working hours are assumed as 8.
    /// - Wage is calculated based on part-time hours.
    /// 
    /// UC-4: Switch Case for Employee Wage
    /// 
    /// UC-5: Monthly Wage Calculation
    /// - A month is assumed to have 20 working days.
    /// - Monthly wage is calculated as Daily Wage × 20 days.
    /// 
    /// UC-56: Wage Calculation Till Condition
    /// - Wages are calculated until either:
    ///   a) Total working days reach 20, OR
    ///   b) Total working hours reach 100.
    /// - Wage accumulation stops when any one condition is satisfied.
    /// 
    /// The program follows a menu-driven approach and uses:
    /// - Encapsulation (Employee class)
    /// - Abstraction (Interface)
    /// - Implementation (Utility class)
    /// - Switch-case menu control
    /// </summary>

    class EmployeeMain
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            new EmployeeMenu();
        }
    }
}
