using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management
{
    public interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

}
