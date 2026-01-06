using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Service_Call_Log_Manager
{
    public class CallLog
    {
        public string phponeNumber;
        public string message;
        public DateTime callTime;

        public CallLog(string phoneNumber, string message, DateTime callTime)
        {
            this.phponeNumber = phoneNumber;
            this.message = message;
            this.callTime = callTime;
        }

        public void DisplayCallLog()
        {
            Console.WriteLine($"Phone Number: {phponeNumber}");
            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Call Time: {callTime}");
        }
    }
}
