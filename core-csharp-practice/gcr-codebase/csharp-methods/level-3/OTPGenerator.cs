using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class OTPGenerator
    {
        public static void Main()
        {
            int[] otps = new int[10];

            for (int i = 0; i < 10; i++)
            {
                otps[i] = GenerateOTP();
                Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
            }

            bool unique = AreOTPsUnique(otps);
            Console.WriteLine("All OTPs Unique: " + unique);
        }

        public static int GenerateOTP()
        {
            Random rand = new Random();
            return rand.Next(100000, 1000000); // 6-digit OTP
        }

        public static bool AreOTPsUnique(int[] otps)
        {
            for (int i = 0; i < otps.Length; i++)
            {
                for (int j = i + 1; j < otps.Length; j++)
                {
                    if (otps[i] == otps[j]) return false;
                }
            }
            return true;
        }
    }
}
