using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BridgeLabzTraining.opps_chsarp_pracitce.cenario_based
{
    public abstract class Patient : IPayable
    {
        public int  PatientId { get; set; }
        public string PatientName { get; set; }
        public int PatientAge { get; set; }

        protected Patient(int patientId, string name, int age)
        {
            PatientId = patientId;
            PatientName = name;
            PatientAge = age;
        }

        public abstract void DisplayInfo();
        public abstract double GenrateBill();


    }
}
