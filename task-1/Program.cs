using System;

namespace Program{
    class Program{
        // Entry point for calculating factorial
        static void Main(string[] args){
            Console.WriteLine("Program to find factorial!");
            Console.WriteLine("Enter a number: ");
            
            // Read and convert user input
            int n = Convert.ToInt32(Console.Read());

            // Validate non-negative input
            if (n < 0){
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return;
            }

            // Iteratively calculate factorial
            long factorial = 1;
            for(int i = 1; i <= n; i++){
                factorial *= i;
            }

            // Display result
            Console.WriteLine("Factorial of {0} is: {1}", n, factorial);
        }
    }
}