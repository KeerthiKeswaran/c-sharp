using System;
using Attributes;

namespace Tasks
{
    public class TaskTwo
    {
        [Runnable]
        public void Execute()
        {
            Console.WriteLine("TaskTwo → Execute executed");
        }
    }
}