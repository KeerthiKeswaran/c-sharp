using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskManager
{
    class Program
    {
        static async Task<string> FetchDataAsync(string sourceName, int delayMs)
        {
            Console.WriteLine($"[Request] Fetching from {sourceName} (will take {delayMs}ms)...");
            // Mimic an API call delay
            await Task.Delay(delayMs);
            return $"Data from {sourceName}";
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting data fetch from simulated sources...\n"); 
            // Start timing the operations
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                // Start multiple tasks concurrently
                Task<string> task1 = FetchDataAsync("User Service", 2000);
                Task<string> task2 = FetchDataAsync("Order Service", 3000);
                Task<string> task3 = FetchDataAsync("Inventory Service", 1500);
                string[] results = await Task.WhenAll(task1, task2, task3);
                stopwatch.Stop(); // Stop timing
                Console.WriteLine("\nAll data fetched successfully:");
                foreach (var result in results)
                {
                    Console.WriteLine("- " + result);
                }
                Console.WriteLine($"\nTotal time taken: {stopwatch.Elapsed.TotalSeconds:F2} seconds");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn error occurred: {ex.Message}");
            }
        }
    }
}
