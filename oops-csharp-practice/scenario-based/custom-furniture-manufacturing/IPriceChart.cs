using System;
using System.Collections.Generic;
using System.Text;

namespace custom_furniture_manufacturing
{
    internal interface IPriceChart
    {
        int GetPrice(int length);
        int MaxLength();
    }
}
