using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.cenario_based
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Name { get; set; }
        public string Specilaization { get; set; }

        public Doctor(int doctorId, string name, string specialization)
        {
            DoctorId = doctorId;
            DoctorName = name;
            Specilaization = specialization;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("---- Doctor Details ----");
            Console.WriteLine($"ID: {DoctorId}");
            Console.WriteLine($"Name: {DoctorName}");
            Console.WriteLine($"Specialization: {Specilaization}");
        }
    }
}
