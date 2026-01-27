using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class ListManagerTests
    {
        private ListManager _listManager = null!;
        private List<int> _list = null!;

        [TestInitialize]
        public void Setup()
        {
            _listManager = new ListManager();
            _list = new List<int>();
        }

        // ✅ Test AddElement
        [TestMethod]
        public void AddElement_AddsItemToList()
        {
            _listManager.AddElement(_list, 10);

            Assert.AreEqual(1, _list.Count);
            Assert.IsTrue(_list.Contains(10));
        }

        // ✅ Test RemoveElement
        [TestMethod]
        public void RemoveElement_RemovesItemFromList()
        {
            _list.Add(10);
            _list.Add(20);

            _listManager.RemoveElement(_list, 10);

            Assert.AreEqual(1, _list.Count);
            Assert.IsFalse(_list.Contains(10));
        }

        // ✅ Test GetSize
        [TestMethod]
        public void GetSize_ReturnsCorrectSize()
        {
            _list.Add(5);
            _list.Add(15);
            _list.Add(25);

            int size = _listManager.GetSize(_list);

            Assert.AreEqual(3, size);
        }
    }
}
