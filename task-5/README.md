# Log File Analyzer

A robust C# command-line application designed for efficient file processing and analysis. This project demonstrates core concepts of File I/O and exception handling by reading server logs, performing statistical analysis, and exporting the results to a summary file.

## Project Objective
The primary goal is to develop a reliable system that can safely interact with the file system, process textual data (counting lines and words), and handle potential runtime errors like missing files or access issues gracefully.

## Key Features
- **File Reading**: Efficiently reads data from standard text files (`.txt`, `.log`).
- **Data Processing**: Automatically calculates total line count and word count.
- **File Export**: Generates a formatted `summary.txt` file containing the analysis results.
- **Robust Exception Handling**: Implements `try-catch` blocks to manage `FileNotFoundException`, `IOException`, and general runtime errors.
- **Professional Logging**: Outputs analysis progress and summary data to the console in real-time.

## Tech Stack
- **Language**: C#
- **Framework**: .NET Core / .NET SDK
- **Runtime**: .NET Runtime

## Project Structure
```text
task-5/
├── Program.cs          # Main application logic and exception handling
├── log.txt             # Sample server log file for analysis
├── task-5.csproj       # .NET project configuration
└── summary.txt         # Generated output file (created after execution)
```

## Setup Instructions

1. **Prerequisites**: Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.
2. **Download**: Clone or download the project files into a local directory.
3. **Open Terminal**: Navigate to the `task-5` folder in your terminal or command prompt.
4. **Restore Dependencies**: (Optional) Run `dotnet restore` to ensure all project dependencies are initialized.

## How to Run
Execute the following command in the project directory:
```powershell
dotnet run
```

## Example Output
**Console Output:**
```text
Log Analysis Summary
--------------------
Processed File: log.txt
Total Lines: 8
Total Words: 54
Analysis Date: 4/13/2026 9:35:00 PM

Results successfully written to summary.txt
```

**Generated `summary.txt`:**
The file will contain the same structured summary as seen in the console output.

## Important Notes & Limitations
- **File Pathing**: The application currently looks for `log.txt` in the root execution directory.
- **Encoding**: Assumes standard UTF-8 encoding for input files.
- **Performance**: Designed for small to medium-sized log files; for extremely large files (GBs), a streaming read approach would be more suitable.

## Future Improvements
- **Regex Parsing**: Implement advanced parsing to categorize logs by severity (INFO, WARNING, ERROR).
- **Dynamic Input**: Allow users to specify the input and output file paths via command-line arguments.
- **Real-time Monitoring**: Add a mode to watch the log file for changes and update the summary dynamically.
