# Student Management Console App

A simple C# console application for managing a list of students, demonstrating basic object-oriented programming, filtering, and sorting operations.

## Key Features

- Add and display student details (name, grade, age)
- Filter students by grade threshold
- Sort students by name or grade (ascending/descending)
- Console-based output for easy interaction

## Tech Stack

- **Language:** C#
- **Framework:** .NET 10.0
- **Type:** Console Application

## Project Structure

```
task-4/
├── Program.cs         # Main application logic and Student class
├── task-4.csproj      # Project configuration
├── bin/               # Build outputs
└── obj/               # Build intermediates
```

## Setup Instructions

1. **Prerequisites:**
   - [.NET 10.0 SDK](https://dotnet.microsoft.com/download) installed
   - Git (optional, for cloning)

2. **Clone the repository** (if applicable):
   ```sh
   git clone <repo-url>
   cd task-4
   ```

3. **Restore dependencies:**
   ```sh
   dotnet restore
   ```

4. **Build the project:**
   ```sh
   dotnet build
   ```

## How to Run

From the `task-4` directory, run:

```sh
 dotnet run
```

## Example Usage / Expected Output

```
Student List:
{ Name: John, Grade: A, Age: 20 } | { Name: Jane, Grade: B, Age: 21 } | { Name: Bob, Grade: C, Age: 22 } | { Name: Alice, Grade: D, Age: 23 } | { Name: Mike, Grade: E, Age: 24 } | 
Filtered Results: John, Jane
Sorted Names: Alice, Bob, Jane, John, Mike
Sorted Grades: John, Jane, Bob, Alice, Mike
```

## Important Notes

- The grade filter uses string comparison; ensure grades follow a consistent format (e.g., A, B, C, ...).
- The application is for demonstration/learning purposes and does not persist data.

## Future Improvements

- Add user input for dynamic student management
- Implement data persistence (e.g., file or database)
- Enhance filtering and sorting options
- Add unit tests for core logic
