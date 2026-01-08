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

        private bool isPartTime { get; set; }
        private double dailyWage { get; set; }

        private double partTimeWage { get; set; }

        private double monthlyWage { get; set; }

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

        public bool IsPartTime
        {
            get { return isPartTime; }
            set { isPartTime = value; }
        }

        public double PartTimeWage
        {
            get { return partTimeWage; }
            set { partTimeWage = value; }
        }

        public double MonthlyWage
        {
            get { return monthlyWage; }
            set { monthlyWage = value; }
        }
        public override string ToString()
        {
            return $"Name : {EmployeeName} || ID : {EmployeeId}  || Present : {IsPresent} || Daily Wage : {DailyWage}  || Part-Time Wage : {PartTimeWage} || Monthly Wage: {MonthlyWage}";
        }

    }
}
