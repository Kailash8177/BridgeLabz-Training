using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    public interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }

}
