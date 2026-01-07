using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Food_Delivery_System
{
    public interface IDiscountable
    {
        double ApplyDiscount();
        string GetDiscountDetails();
    }

}
