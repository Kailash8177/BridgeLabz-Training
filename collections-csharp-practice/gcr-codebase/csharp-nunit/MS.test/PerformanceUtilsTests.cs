using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class PerformanceUtilsTests
    {
        private PerformanceUtils _performanceUtils = null!;

        [TestInitialize]
        public void Setup()
        {
            _performanceUtils = new PerformanceUtils();
        }

        // ❌ This test will FAIL (3 sec > 2 sec)
        [TestMethod]
        [Timeout(2000)]
        public void LongRunningTask_ShouldCompleteWithin2Seconds()
        {
            _performanceUtils.LongRunningTask();
        }
    }
}
