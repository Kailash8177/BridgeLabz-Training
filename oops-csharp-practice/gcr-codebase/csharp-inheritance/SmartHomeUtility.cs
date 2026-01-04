using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_inheritance
{
    // ---------------- Superclass ----------------
    class Device
    {
        // Common attributes for all devices
        public int DeviceId;
        public string Status;

        // Virtual method to show device status
        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
        }
    }

    // ---------------- Subclass ----------------
    class Thermostat : Device
    {
        // Specific attribute for Thermostat
        public int TemperatureSetting;

        // Override method to add more details
        public override void DisplayStatus()
        {
            Console.WriteLine(
                $"Device ID: {DeviceId}, Status: {Status}, Temperature: {TemperatureSetting}°C"
            );
        }
    }

    // ---------------- Utility Class ----------------
    class SmartHomeUtility
    {
        public static void Main()
        {
            Thermostat thermostat = new Thermostat
            {
                DeviceId = 101,
                Status = "ON",
                TemperatureSetting = 24
            };

            thermostat.DisplayStatus();
        }
    }
}
