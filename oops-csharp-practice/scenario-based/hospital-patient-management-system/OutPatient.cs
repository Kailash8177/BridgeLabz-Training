using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.cenario_based
{
    public class OutPatient : Patient
    {
        public double ConsulationFee { get; set; }

        public OutPatient(int patientId, string name, int age, double fee) : base(patientId, name, age)
        {
            ConsulationFee = fee;
        }
        public override double GenrateBill()
        {
            return ConsulationFee;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("---- OutPatient Details ----");
            Console.WriteLine($"ID: {PatientId}");
            Console.WriteLine($"Name: {PatientName}");
            Console.WriteLine($"Age: {PatientAge}");
            Console.WriteLine($"Total Bill: {GenrateBill()}");
        }

    }
}
