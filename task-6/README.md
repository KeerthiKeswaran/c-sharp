# Event-Driven Counter System

A demonstration of C# event-driven programming patterns using delegates and events. This project simulates a counter that monitors its own state and notifies multiple decoupled subscribers once a predefined threshold is reached.

## Project Objective
The goal is to master the implementation of **Delegates** and **Events** in C# to create decoupled systems where the "Producer" (the counter) does not need to know the specific implementation details of its "Consumers" (the event handlers).

## Logic Decoupling (Producer vs Consumer)
This project explicitly demonstrates decoupling using the Observer pattern via C# Events:
- **The Producer (Counter class)**: Solely responsible for maintaining state and identifying when the threshold is reached. It has zero knowledge of what the "subscribers" do with that information.
- **The Consumer (Event Handlers)**: Independent methods that execute specific logic (printing to console, logging, etc.) when notified. They don't interfere with the counter's operation.

This separation of concerns makes the system highly maintainable and extensible.

## Key Features
- **Custom Event System**: Uses `System.Action<int>` delegates to manage event notifications.
- **Multiple Subscribers**: Demonstrates the multi-cast capability of events by attaching multiple handlers (`notification_event` and `log_event`) to a single source.
- **Logic Decoupling**: The counter logic remains independent of the logging and notification logic.
- **Threshold Triggering**: Real-time monitoring of state to fire events exactly when specific conditions are met.

## Tech Stack
- **Language**: C#
- **Framework**: .NET Core / .NET SDK
- **Patterns**: Event-driven Architecture / Observer Pattern

## Project Structure
```text
task-6/
├── Program.cs          # Contains the Counter class and Main entry point
└── task-6.csproj       # .NET project configuration
```

## Setup Instructions

1. **Check Prerequisites**: Install the [.NET SDK](https://dotnet.microsoft.com/download).
2. **Environment**: Access the `task-6` directory via your preferred terminal.
3. **Build**: (Optional) Run `dotnet build` to verify the code structure.

## How to Run
Execute the following command in the project directory:
```powershell
dotnet run
```

## Example Usage or Expected Output
**Console Output:**
```text
Incrementing Count as: 1
Incrementing Count as: 2
Incrementing Count as: 3
Incrementing Count as: 4
Incrementing Count as: 5
Threshold Reached: 5
Threshold Reached: 5
```
*(Note: "Threshold Reached" appears twice because two separate methods are subscribed to the event.)*

## Important Notes or Limitations
- **Delegate Type**: Utilizes the built-in `Action<int>` delegate for simplicity; custom delegates can be swapped in for more complex signatures.
- **Loop Limit**: The demonstration loop is configured to pass the threshold to show that the event only fires at the exact moment of intersection.

## Future Improvements
- **Dynamic Threshold**: Add the ability to pass the threshold value as a command-line argument.
- **Custom EventArgs**: Implement a custom class inheriting from `EventArgs` to pass richer metadata (e.g., timestamp, source) to subscribers.
- **Unsubscription Logic**: Demonstrate the use of `-=` to remove handlers dynamically during runtime.
