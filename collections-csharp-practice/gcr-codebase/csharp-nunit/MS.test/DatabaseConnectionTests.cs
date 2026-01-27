using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection _dbConnection = null!;

        // 🔹 Runs BEFORE each test
        [TestInitialize]
        public void Setup()
        {
            _dbConnection = new DatabaseConnection();
            _dbConnection.Connect();
        }

        // 🔹 Runs AFTER each test
        [TestCleanup]
        public void Cleanup()
        {
            _dbConnection.Disconnect();
        }

        [TestMethod]
        public void Connect_ShouldEstablishConnection()
        {
            Assert.IsTrue(_dbConnection.IsConnected);
        }

        [TestMethod]
        public void Disconnect_ShouldCloseConnection()
        {
            _dbConnection.Disconnect();
            Assert.IsFalse(_dbConnection.IsConnected);
        }
    }
}
