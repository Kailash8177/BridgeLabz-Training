using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace NUnit.Test
{
    [TestFixture]
    public class FileProcessorTests
    {
        private FileProcessor _fileProcessor = null!;
        private string _testFilePath = null!;

        [SetUp]
        public void Setup()
        {
            _fileProcessor = new FileProcessor();
            _testFilePath = Path.Combine(Path.GetTempPath(), "testfile.txt");
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(_testFilePath))
                File.Delete(_testFilePath);
        }

        [Test]
        public void WriteAndRead_File_ReturnsCorrectContent()
        {
            string content = "Hello NUnit";

            _fileProcessor.WriteToFile(_testFilePath, content);
            string result = _fileProcessor.ReadFromFile(_testFilePath);

            Assert.AreEqual(content, result);
        }

        [Test]
        public void WriteToFile_FileExistsAfterWrite()
        {
            _fileProcessor.WriteToFile(_testFilePath, "Test");

            Assert.IsTrue(File.Exists(_testFilePath));
        }

        [Test]
        public void ReadFromFile_FileDoesNotExist_ThrowsIOException()
        {
            Assert.Throws<IOException>(() =>
            {
                _fileProcessor.ReadFromFile("missing.txt");
            });
        }
    }
}
