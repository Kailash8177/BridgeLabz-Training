using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_this_static_sealed_is
{
    public class HospitalUtility
    {
        public static void Main()
        {
            object p = new Patient("Asha", 30, "Fever", 701);

            if (p is Patient)
            {
                ((Patient)p).Display();
            }

            Patient.GetTotalPatients();
        }

    }
    public class Patient
    {
        public static string HospitalName = "City Hospital";
        private static int totalPatients = 0;

        public readonly int PatientID;
        public string Name;
        public int Age;
        public string Ailment;

        public Patient(string name, int age, string ailment, int patientId)
        {
            this.Name = name;
            this.Age = age;
            this.Ailment = ailment;
            this.PatientID = patientId;
            totalPatients++;
        }

        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients: " + totalPatients);
        }

        public void Display()
        {
            Console.WriteLine($"{HospitalName} | {Name} | {PatientID} | {Ailment}");
        }
    }
}
