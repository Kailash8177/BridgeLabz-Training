using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace NUnit.Test
{
    [TestFixture]
    public class TemperatureConverterTests
    {
        private TemperatureConverter _converter = null!;

        [SetUp]
        public void Setup()
        {
            _converter = new TemperatureConverter();
        }

        [TestCase(0, 32)]
        [TestCase(100, 212)]
        public void CelsiusToFahrenheit_ReturnsExpected(double celsius, double expected)
        {
            Assert.That(
                _converter.CelsiusToFahrenheit(celsius),
                Is.EqualTo(expected).Within(0.001)
            );
        }

        [TestCase(32, 0)]
        [TestCase(212, 100)]
        public void FahrenheitToCelsius_ReturnsExpected(double fahrenheit, double expected)
        {
            Assert.That(
                _converter.FahrenheitToCelsius(fahrenheit),
                Is.EqualTo(expected).Within(0.001)
            );
        }
    }
}
