using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace NUnit.Test
{
    [TestFixture]
    public class ListManagerTests
    {
        private ListManager _listManager = null!;
        private List<int> _list = null!;

        [SetUp]
        public void Setup()
        {
            _listManager = new ListManager();
            _list = new List<int>();
        }

        [Test]
        public void AddElement_AddsItemToList()
        {
            _listManager.AddElement(_list, 10);

            Assert.That(_list.Count, Is.EqualTo(1));
            Assert.That(_list, Does.Contain(10));
        }

        [Test]
        public void RemoveElement_RemovesItemFromList()
        {
            _list.Add(10);
            _list.Add(20);

            _listManager.RemoveElement(_list, 10);

            Assert.That(_list.Count, Is.EqualTo(1));
            Assert.That(_list, Does.Not.Contain(10));
        }

        [Test]
        public void GetSize_ReturnsCorrectSize()
        {
            _list.Add(1);
            _list.Add(2);
            _list.Add(3);

            Assert.That(_listManager.GetSize(_list), Is.EqualTo(3));
        }
    }
}
