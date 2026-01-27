using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class TemperatureConverterTests
    {
        private TemperatureConverter _converter = null!;

        [TestInitialize]
        public void Setup()
        {
            _converter = new TemperatureConverter();
        }

        // ✅ Celsius → Fahrenheit
        [TestMethod]
        public void CelsiusToFahrenheit_Zero_Returns32()
        {
            double result = _converter.CelsiusToFahrenheit(0);

            Assert.AreEqual(32, result, 0.001);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_Hundred_Returns212()
        {
            double result = _converter.CelsiusToFahrenheit(100);

            Assert.AreEqual(212, result, 0.001);
        }

        // ✅ Fahrenheit → Celsius
        [TestMethod]
        public void FahrenheitToCelsius_ThirtyTwo_ReturnsZero()
        {
            double result = _converter.FahrenheitToCelsius(32);

            Assert.AreEqual(0, result, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_TwoTwelve_ReturnsHundred()
        {
            double result = _converter.FahrenheitToCelsius(212);

            Assert.AreEqual(100, result, 0.001);
        }
    }
}
