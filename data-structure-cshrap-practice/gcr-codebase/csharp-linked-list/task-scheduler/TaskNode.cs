using System;
using System.Collections.Generic;
using System.Text;

namespace task_scheduler
{
    class TaskNode
    {
        public int TaskId;
        public string Name;
        public int Priority;
        public TaskNode Next;

        public TaskNode(int id, string name, int priority)
        {
            TaskId = id;
            Name = name;
            Priority = priority;
        }
    }
}
