using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BridgeLabzTraining.opps_chsarp_pracitce.cenario_based
{
    public class InPatient : Patient
    {
        public int NumberOfDays {  get; set; }
        public double DailyCharge  { get; set; }

        public InPatient(int patientId, string name, int age, int days, double charge) : base(patientId, name, age)
        {
            NumberOfDays = days;
            DailyCharge = charge;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("---- InPatient Details ----");
            Console.WriteLine($"ID: {PatientId}");
            Console.WriteLine($"Name: {PatientName}");
            Console.WriteLine($"Age: {PatientAge}");
            Console.WriteLine($"Days Admitted: {NumberOfDays}");
            Console.WriteLine($"Total Bill: {GenrateBill()}");
        }

        public override double GenrateBill()
        {
            return NumberOfDays *DailyCharge;
        }

    }
}
