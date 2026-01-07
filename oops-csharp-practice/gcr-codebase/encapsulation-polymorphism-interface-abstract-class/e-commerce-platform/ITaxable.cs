using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce_platform
{
    internal interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }
}
