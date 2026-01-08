using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    internal class Employee
    {
        // private fields with getter and seeter methods
        private int employeeId { get; set; }
        private string employeeName { get; set; }

        private bool isPresent { get; set; }

        private double dailyWage { get; set; }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public bool IsPresent
        {
            get { return isPresent; }
            set { isPresent = value; }
        }

        // no constructor

        // override tostring

        public double DailyWage
        {
            get { return dailyWage; }
            set { dailyWage = value; }
        }

        public override string ToString()
        {
            return $"Name : {EmployeeName} || ID : {EmployeeId}  || Present : {IsPresent} || Daily Wage : {DailyWage}";
        }

    }
}
