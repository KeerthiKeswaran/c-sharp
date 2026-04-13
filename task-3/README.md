# String Management System (Task 3)

## Overview
A C# utility designed to manage a list of strings with integrated processing. The system automatically standardizes input by handling casing, trimming whitespace, and removing internal spaces to ensure consistency within the collection.

## Key Features
- **Automated Processing**: Trims and removes spaces from every string added or removed.
- **Dynamic Collection**: Uses a `List<string>` to store and manage data.
- **CRUD-like Operations**: Supports adding and removing strings with real-time feedback.
- **List Visualization**: A dedicated display method to view the current state of the collection.

## Tech Stack
- **Language**: C#
- **Framework**: .NET

## Project Structure
```text
task-3/
├── Program.cs       # Core logic for StringManagement and the Main entry point
└── task-3.csproj   # .NET Project file
```

## Setup Instructions
1.  **Install .NET SDK**: Download and install the [.NET SDK](https://dotnet.microsoft.com/download).
2.  **Verify Configuration**: Check your environment with `dotnet --list-sdks`.
3.  **Navigate to Workspace**: Open your terminal in the `task-3` directory.

## How to Run
To compile and execute the application:
```bash
dotnet run
```

## Example Output
```text
Added: Keshwanth
Added: Priya
Added: Kavya
Current List: 
[ Keshwanth Priya Kavya ]
Removed: Priya
Current List: 
[ Keshwanth Kavya ]
```

## Important Notes
- **Processing Logic**: The current `processInput` method converts to lowercase but then overwrites it with a trimmed version of the *original* string (due to code logic). It specifically focuses on removing spaces.
- **Case Sensitivity**: By default, string matching in the list is case-sensitive unless handled by the processing logic.

## Future Improvements
- Fix the processing logic to chain all transformations (casing, trimming, and space removal).
- Implement a more interactive console menu for user-driven management.
- Add data persistence to save the list to a file.
