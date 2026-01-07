using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management
{
    public class Utility
    {
        public static void Main()
        {
            List<Patient> patients = new List<Patient>
        {
            new InPatient(101, "Rahul", 30, 5, 2000),
            new OutPatient(202, "Anita", 25, 800)
        };

            foreach (Patient patient in patients)
            {
                patient.GetPatientDetails();
                Console.WriteLine($"Bill Amount: ₹{patient.CalculateBill()}");

                if (patient is IMedicalRecord record)
                {
                    record.AddRecord("General Checkup");
                    record.AddRecord("Prescribed Medicines");
                    record.ViewRecords();
                }

                Console.WriteLine("----------------------------------");
            }
        }
    }
}
