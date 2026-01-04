using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_obejct_oriented_design.object_modeling
{

    // ---------------- Doctor ----------------
    class Doctor
    {
        public string Name;

        public void Consult(Patient patient)
        {
            Console.WriteLine($"Doctor {Name} consulted {patient.Name}");
        }
    }

    // ---------------- Patient ----------------
    class Patient
    {
        public string Name;
    }

    // ---------------- Utility ----------------
    class HospitalUtility
    {
        public static void Main()
        {
            Doctor d = new Doctor { Name = "Dr. Rao" };
            Patient p = new Patient { Name = "Amit" };

            d.Consult(p);
        }
    }
}
