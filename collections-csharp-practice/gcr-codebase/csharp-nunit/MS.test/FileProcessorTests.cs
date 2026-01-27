using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class FileProcessorTests
    {
        private FileProcessor _fileProcessor = null!;
        private string _testFilePath = null!;

        [TestInitialize]
        public void Setup()
        {
            _fileProcessor = new FileProcessor();
            _testFilePath = Path.Combine(
                Path.GetTempPath(),
                Guid.NewGuid().ToString() + ".txt"
            );
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(_testFilePath))
                File.Delete(_testFilePath);
        }

        [TestMethod]
        public void WriteAndRead_File_ReturnsCorrectContent()
        {
            string content = "Hello File Test";

            _fileProcessor.WriteToFile(_testFilePath, content);
            string result = _fileProcessor.ReadFromFile(_testFilePath);

            Assert.AreEqual(content, result);
        }


        [TestMethod]
        public void WriteToFile_FileExistsAfterWrite()
        {
            _fileProcessor.WriteToFile(_testFilePath, "Test");

            Assert.IsTrue(File.Exists(_testFilePath));
        }

        [TestMethod]
        public void ReadFromFile_FileDoesNotExist_ThrowsIOException()
        {
            try
            {
                _fileProcessor.ReadFromFile(_testFilePath);
                Assert.Fail("Expected IOException was not thrown.");
            }
            catch (IOException)
            {
                // pass
            }
        }
    }
}
