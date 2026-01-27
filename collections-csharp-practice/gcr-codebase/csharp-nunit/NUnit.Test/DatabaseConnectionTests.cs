using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace NUnit.Test
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection _dbConnection = null!;

        // 🔹 Runs BEFORE each test
        [SetUp]
        public void Setup()
        {
            _dbConnection = new DatabaseConnection();
            _dbConnection.Connect();
        }

        // 🔹 Runs AFTER each test
        [TearDown]
        public void TearDown()
        {
            _dbConnection.Disconnect();
        }

        [Test]
        public void Connect_ShouldEstablishConnection()
        {
            Assert.IsTrue(_dbConnection.IsConnected);
        }

        [Test]
        public void Disconnect_ShouldCloseConnection()
        {
            _dbConnection.Disconnect();
            Assert.IsFalse(_dbConnection.IsConnected);
        }
    }
}
