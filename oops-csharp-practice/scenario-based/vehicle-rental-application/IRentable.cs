using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalApplication
{
    public interface IRentable
    {
        double CalculateRent(int Days);
    }
}
