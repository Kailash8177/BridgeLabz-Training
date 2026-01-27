using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class DateFormatter
    {
        public string FormatDate(string inputDate)
        {
            if (string.IsNullOrWhiteSpace(inputDate))
                throw new FormatException("Input date is invalid");

            DateTime date = DateTime.ParseExact(
                inputDate,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture
            );

            return date.ToString("dd-MM-yyyy");
        }
    }
}
