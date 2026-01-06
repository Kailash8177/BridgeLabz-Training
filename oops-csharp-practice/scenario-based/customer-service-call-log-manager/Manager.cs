using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Service_Call_Log_Manager
{
    public class Manager
    {
        private CallLog[] callLogs;
        private int logCount;

        public Manager(int maxLogs)
        {
            callLogs = new CallLog[maxLogs];
            logCount = 0;
        }

        public void AddCallLog (string number, string msg , DateTime dateTime)
        {
            if (logCount >= callLogs.Length)
            {
                Console.WriteLine("Call log is full. Cannot add more logs.");
                return;
            }
            callLogs[logCount] = new CallLog(number, msg, dateTime);
            logCount++;
        }

        public void SearchByKeyword(string keyword)
        {
            bool found = true;
            for (int i = 0; i < logCount; i++)
            {
                if (callLogs[i].message.Contains(keyword.ToLower()))
                {
                    callLogs[i].DisplayCallLog();
                    Console.WriteLine("-----------------------");
                    found = false;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("No call logs found with the given keyword.");
            }

        }

        public void FilterByTime(DateTime startTime , DateTime endTime)
        { 
            bool found = true;
            for (int i = 0; i < logCount; i++)
            {
                if (callLogs[i].callTime >= startTime && callLogs[i].callTime <= endTime)
                {
                    callLogs[i].DisplayCallLog();
                    Console.WriteLine("-----------------------");
                    found = false;
                }
            }
            if (found)
            {
                Console.WriteLine("No call logs found in the given time range.");
            }
        }
    }
}
