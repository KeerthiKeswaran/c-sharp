# Person Introduction System (Task 2)

## Overview
This project demonstrates the core principles of Object-Oriented Programming (OOP) in C#. It features a `Person` class that encapsulates data and behavior, showcasing how to define classes, use constructors, and invoke methods on objects.

## Key Features
- **Capsulation**: Stores person details (name and age) within private fields.
- **Initialization**: Utilizes a constructor for setting up object state.
- **Interaction**: Includes an `introduce()` method to output a personalized greeting.
- **Object Instantiation**: Demonstrates creating multiple instances of a class with unique data.

## Tech Stack
- **Language**: C#
- **Framework**: .NET

## Project Structure
```text
task-2/
├── Program.cs       # Main source code containing Class definitions and entry point
└── task-2.csproj   # Project configuration file
```

## Setup Instructions
1.  **Install .NET SDK**: Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.
2.  **Verify Installation**: Run `dotnet --version` in your terminal to confirm.
3.  **Navigate to Project**: Open your terminal and go to the `task-2` directory.

## How to Run
Execute the following command in the project directory:
```bash
dotnet run
```

## Example Output
```text
Hello, my name is Keshwanth and I am 21 years old.
Hello, my name is Priya and I am 25 years old.
```

## Important Notes
- This is a console-based application designed for educational purposes.
- Fields in the `Person` class are internal by default; consider using properties for better encapsulation in production code.

## Future Improvements
- Add more attributes like 'City' or 'Occupation'.
- Implement input validation for age.
- Add support for reading person data from a file or user input.
