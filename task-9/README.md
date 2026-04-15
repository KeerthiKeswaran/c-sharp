# Task 9: Reflection and Custom Attributes in C#

## Overview

This project demonstrates how to use reflection and custom attributes in C# to discover and execute methods dynamically. Methods decorated with a custom `[Runnable]` attribute are automatically found and invoked at runtime, showcasing advanced .NET metaprogramming techniques.

## Key Features

- Custom attribute `[Runnable]` for marking methods to be executed
- Multiple classes with methods decorated by `[Runnable]`
- Reflection-based discovery of all `[Runnable]` methods in the assembly
- Dynamic invocation of discovered methods
- Console output showing which methods were executed

## Tech Stack

- **Language:** C#
- **Framework:** .NET (Console Application)
- **Core Concepts:** Reflection, Custom Attributes, Dynamic Invocation

## Project Structure

```
task-9/
│
├── Attributes/
│   └── Runnable.cs         # Definition of the [Runnable] attribute
├── Core/
│   └── Runner.cs           # Reflection logic to find and execute methods
├── Tasks/
│   ├── TaskOne.cs          # Example class with [Runnable] method(s)
│   └── TaskTwo.cs          # Another example class with [Runnable] method(s)
├── Program.cs              # Application entry point
├── task-9.csproj           # Project file
└── README.md               # Project documentation
```

## Setup Instructions

1. **Prerequisites:**
   - [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)

2. **Clone the repository:**
   ```
   git clone <repository-url>
   cd task-9
   ```

3. **Restore dependencies:**
   ```
   dotnet restore
   ```

## How to Run the Project

From the task-9 directory, execute:

```
dotnet run
```

This will build and launch the console application.

## Example Usage / Expected Output

When you run the application, you will see output similar to:

```
Starting Runner...

TaskOne → Run executed
TaskTwo → Execute executed

Execution Completed.
```

- Only methods marked with `[Runnable]` are executed.
- Methods without the attribute (e.g., `NotRunnable`) are ignored.
