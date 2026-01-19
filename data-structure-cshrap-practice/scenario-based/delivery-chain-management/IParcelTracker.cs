using System;
using System.Collections.Generic;
using System.Text;

namespace delivery_chain_management
{
    internal interface IParcelTracker
    {
        void AddStage(string stageName);
        void AddCheckPoint(string afterStage, string newStage);
        void TrackParcel();
        void CheckParcel();

    }
}
