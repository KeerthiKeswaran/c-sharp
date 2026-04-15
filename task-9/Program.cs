using System;
using Core;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Runner...\n");

            var runner = new Runner();

            runner.ExecuteAll();

            Console.WriteLine("\nExecution Completed.");
        }
    }
}