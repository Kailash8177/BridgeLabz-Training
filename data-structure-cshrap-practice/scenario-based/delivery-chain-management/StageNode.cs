using System;
using System.Collections.Generic;
using System.Text;

namespace delivery_chain_management
{
    internal class StageNode
    {
        public string stageName;
        public StageNode next;
        
        public StageNode(string stageName)
        {

            this.stageName = stageName;
            next = null;
        }
    }
}
