# Asynchronous Multi-Source Data Fetcher

A professional C# console application designed to demonstrate the power of asynchronous programming and multi-threading. This project simulates real-world scenarios where data must be fetched concurrently from multiple independent services (like User, Order, and Inventory APIs).

## Project Objective
The goal is to master **Asynchronous Programming** using the `async` and `await` keywords. The application focuses on executing multiple operations concurrently, aggregating their results, and managing potential failures without blocking the main execution thread.

## Key Features
- **Concurrent Operations**: Initiates multiple data fetch tasks simultaneously to minimize total execution time.
- **Async/Await Pattern**: Implements non-blocking calls using the standard .NET asynchronous pattern.
- **Task Aggregation**: Uses `Task.WhenAll` to wait for all simulated API calls to finish before processing results.
- **Error Simulation & Handling**: Includes robust `try-catch` blocks to manage exceptions that might occur during background operations.
- **Telemetry Simulation**: Provides time-based feedback (`Task.Delay`) to mimic network latency.

## Tech Stack
- **Language**: C#
- **Framework**: .NET Core / .NET SDK
- **Core Library**: `System.Threading.Tasks`

## Project Structure
```text
task-7/
├── Program.cs          # Main logic for async operations and result aggregation
└── task-7.csproj       # .NET project configuration
```

## Setup Instructions

1. **Verify Environment**: Ensure the [.NET SDK](https://dotnet.microsoft.com/download) is installed.
2. **Access Project**: Open your terminal in the `task-7` directory.
3. **Build**: Run `dotnet build` to ensure the environment is correctly configured.

## How to Run
Run the application using the following command:
```powershell
dotnet run
```

## Example Usage or Expected Output
**Console Output:**
```text
Starting data fetch from simulated sources...

[Request] Fetching from User Service (will take 2000ms)...
[Request] Fetching from Order Service (will take 3000ms)...
[Request] Fetching from Inventory Service (will take 1500ms)...

All data fetched successfully:
- Data from User Service
- Data from Order Service
- Data from Inventory Service

Application complete.
```

## Important Notes or Limitations
- **Concurrency vs Parallelism**: This project primarily demonstrates concurrency using tasks on the thread pool.
- **Exception Aggregation**: When using `Task.WhenAll`, if multiple tasks fail, the `catch` block captures the first exception. For complex scenarios, checking `Task.Exception` (AggregateException) is recommended.

## Future Improvements
- **Real API Integration**: Replace simulations with actual HTTP requests using `HttpClient`.
- **Progress Reporting**: Implement `IProgress<T>` to show real-time percentage completion for each task.
- **Cancellation Tokens**: Add `CancellationToken` support to allow users to stop long-running fetches.
