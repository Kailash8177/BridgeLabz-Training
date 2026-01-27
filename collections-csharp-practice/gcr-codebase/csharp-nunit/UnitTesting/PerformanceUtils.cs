using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UnitTesting
{
    public class PerformanceUtils
    {
        public int LongRunningTask()
        {
            Thread.Sleep(1000); // 3 seconds
            return 1;
        }
    }
}
