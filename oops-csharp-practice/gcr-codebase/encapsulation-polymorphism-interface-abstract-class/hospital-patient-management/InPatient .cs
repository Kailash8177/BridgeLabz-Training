using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management
{
    public class InPatient : Patient, IMedicalRecord
    {
        public int NumberOfDays { get; set; }
        public double DailyCharge { get; set; }

        public InPatient(int id, string name, int age, int days, double dailyCharge)
            : base(id, name, age)
        {
            NumberOfDays = days;
            DailyCharge = dailyCharge;
        }

        public override double CalculateBill()
        {
            return NumberOfDays * DailyCharge;
        }

        public void AddRecord(string record)
        {
            AddMedicalHistory(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("InPatient Medical Records:");
            foreach (var record in GetMedicalHistory())
            {
                Console.WriteLine("- " + record);
            }
        }
    }

}
