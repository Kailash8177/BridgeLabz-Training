using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    internal interface IEmployee
    {

        Employee AddEmployee();

        void DisplayEmployeeDetails(Employee employees);
        void CheckAttendance(Employee employee);
        void CalculateDailyWage(Employee employee);

    }
}
