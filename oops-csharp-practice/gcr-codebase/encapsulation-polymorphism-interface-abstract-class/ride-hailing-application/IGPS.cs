using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Hailing_Application
{
    public interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string location);
    }

}
