# Task 1: Factorial Calculator Console Application

## Overview
This project is a simple C# console application that calculates the factorial of a given number. It demonstrates the use of basic data types, control structures, and methods in C#.

## Key Features
- Reads an integer input from the user
- Validates input to ensure it is a non-negative integer
- Calculates factorial using a loop
- Displays the result in the console
- Handles invalid (negative) input gracefully

## Tech Stack
- **Language:** C#
- **Framework:** .NET 10.0
- **Type:** Console Application

## Project Structure
```
task-1/
├── Program.cs           # Main application logic
├── task-1.csproj        # Project configuration
├── bin/                 # Compiled binaries
├── obj/                 # Build objects and intermediate files
└── README.md            # Project documentation
```

## Setup Instructions
1. **Prerequisites:**
   - [.NET 10.0 SDK](https://dotnet.microsoft.com/download) installed
   - A terminal or command prompt

2. **Clone or Download the Repository:**
   - Place the project in your desired directory.

3. **Navigate to the Project Directory:**
   ```sh
   cd task-1
   ```

4. **Restore Dependencies (if needed):**
   ```sh
   dotnet restore
   ```

## How to Run the Project
1. **Build the Application:**
   ```sh
   dotnet build
   ```
2. **Run the Application:**
   ```sh
   dotnet run
   ```

## Example Usage
```
Program to find factorial!
Enter a number:
5
Factorial of 5 is: 120
```

If a negative number is entered:
```
Program to find factorial!
Enter a number:
-3
Factorial is not defined for negative numbers.
```

## Important Notes
- Only non-negative integers are accepted for factorial calculation.
- The program uses a loop for factorial calculation (not recursion).
- For very large numbers, the result may exceed the range of `long` and cause incorrect output.

## Future Improvements
- Add input validation for non-integer values.
- Support larger numbers using `BigInteger`.
- Implement a recursive version for educational purposes.
- Add unit tests for core logic.
