using System;
using Attributes;

namespace Tasks
{
    public class TaskOne
    {
        [Runnable]
        public void Run()
        {
            Console.WriteLine("TaskOne → Run executed");
        }

        public void NotRunnable()
        {
            Console.WriteLine("This should NOT run");
        }
    }
}