using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management
{ 
    public abstract class Patient
    {
        private string diagnosis;                 // Encapsulated (Sensitive)
        private List<string> medicalHistory;      // Encapsulated

        public int PatientId { get; protected set; }
        public string Name { get; protected set; }
        public int Age { get; protected set; }

        protected Patient(int id, string name, int age)
        {
            PatientId = id;
            Name = name;
            Age = age;
            medicalHistory = new List<string>();
        }

        protected void SetDiagnosis(string diag)
        {
            diagnosis = diag;
        }

        protected void AddMedicalHistory(string record)
        {
            medicalHistory.Add(record);
        }

        protected List<string> GetMedicalHistory()
        {
            return medicalHistory;
        }

        public void GetPatientDetails()
        {
            Console.WriteLine($"ID: {PatientId}, Name: {Name}, Age: {Age}");
        }

        public abstract double CalculateBill();
    }

}
