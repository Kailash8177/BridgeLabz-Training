using System;
using System.Collections.Generic;
using System.Text;

namespace round_robin_scheduling
{
    /*
 * ProcessNode represents a single process in CPU scheduling.
 * Each node stores process ID, burst time, and link to next process.
 */
    class ProcessNode
    {
        public int Pid, Burst;
        public ProcessNode Next;

        // Constructor to initialize process details
        public ProcessNode(int id, int burst)
        {
            Pid = id;
            Burst = burst;
            Next = null;
        }
    }
}
