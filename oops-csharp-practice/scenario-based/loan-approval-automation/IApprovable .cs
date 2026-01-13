using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace loan_approval_automation
{
    internal interface IApprovable
    {
        bool ApproveLoan();
        double CalculateEMI();
    }
}
