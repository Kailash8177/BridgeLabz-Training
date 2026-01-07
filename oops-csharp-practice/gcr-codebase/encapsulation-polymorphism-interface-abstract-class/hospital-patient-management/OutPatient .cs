using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management
{
    public class OutPatient : Patient, IMedicalRecord
    {
        public double ConsultationFee { get; set; }

        public OutPatient(int id, string name, int age, double fee)
            : base(id, name, age)
        {
            ConsultationFee = fee;
        }

        public override double CalculateBill()
        {
            return ConsultationFee;
        }

        public void AddRecord(string record)
        {
            AddMedicalHistory(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("OutPatient Medical Records:");
            foreach (var record in GetMedicalHistory())
            {
                Console.WriteLine("- " + record);
            }
        }
    }

}
