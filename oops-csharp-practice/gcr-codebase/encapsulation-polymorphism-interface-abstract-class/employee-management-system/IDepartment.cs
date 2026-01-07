using System;
using System.Collections.Generic;
using System.Text;

namespace employee_management_system
{
    internal interface IDepartment
    {
        void AssignDepartment(string departmentName);
        string GetDepartmentDetails();
    }
}
