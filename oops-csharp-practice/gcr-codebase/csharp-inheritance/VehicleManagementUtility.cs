using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_inheritance
{
    // ---------------- Interface ----------------
    interface Refuelable
    {
        void Refuel();
    }

    // ---------------- Superclass ----------------
    class Vehicle
    {
        public int MaxSpeed;
        public string Model;
    }

    // ---------------- Electric Vehicle ----------------
    class ElectricVehicle : Vehicle
    {
        public void Charge()
        {
            Console.WriteLine("Electric vehicle is charging");
        }
    }

    // ---------------- Petrol Vehicle ----------------
    class PetrolVehicle : Vehicle, Refuelable
    {
        public void Refuel()
        {
            Console.WriteLine("Petrol vehicle is refueling");
        }
    }

    // ---------------- Utility Class ----------------
    class VehicleManagementUtility
    {
        public static void Main()
        {
            PetrolVehicle petrolCar = new PetrolVehicle();
            ElectricVehicle ev = new ElectricVehicle();

            petrolCar.Refuel();
            ev.Charge();
        }
    }
}
