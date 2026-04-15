# Task 10: RESTful Product API with C# Client

## Overview

This project demonstrates a full-stack .NET solution with a RESTful Web API for product management and a C# console client that interacts with the API. The server provides CRUD operations for products using Entity Framework Core and SQLite, while the client performs and displays these operations via HTTP requests.

## Key Features

- ASP.NET Core Web API for product CRUD (Create, Read, Update, Delete)
- Entity Framework Core with SQLite database
- Custom middleware for exception handling
- Swagger/OpenAPI documentation for easy API testing
- C# console client for automated API interaction and demonstration
- Clean separation of server and client projects

## Tech Stack

- **Backend:** ASP.NET Core, Entity Framework Core, SQLite
- **Frontend/Client:** C# Console Application, HttpClient
- **Other:** Swagger (OpenAPI), Dependency Injection

## Project Structure

```
task-10/
│
├── client/
│   ├── Program.cs            # Console client for API interaction
│   └── client.csproj
│
├── server/
│   ├── Controller/
│   │   └── ProductController.cs   # API endpoints for products
│   ├── Data/
│   ├── Middleware/
│   ├── Migrations/
│   ├── Models/
│   │   └── Products.cs       # Product entity model
│   ├── Services/
│   │   ├── InterfaceProductService.cs
│   │   └── ProductService.cs
│   ├── Program.cs            # API startup and configuration
│   ├── appsettings.json
│   ├── products.db           # SQLite database file
│   └── server.csproj
│
└── README.md
```

## Setup Instructions

1. **Prerequisites:**
    - [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
    - .NET EF Core Tools: Install globally with
       ```
       dotnet tool install --global dotnet-ef
       ```
    - Or

    -  ```
       dotnet restore //Will Install packages from the .csproj file.
       ```  
       
    - The following NuGet packages are required (restored automatically, but listed for reference):
       - Microsoft.EntityFrameworkCore
       - Microsoft.EntityFrameworkCore.Sqlite
       - Microsoft.EntityFrameworkCore.Design
       - Microsoft.EntityFrameworkCore.Tools
       - Swashbuckle.AspNetCore

2. **Clone the repository:**
   ```
   git clone <repository-url>
   cd task-10
   ```

3. **Restore dependencies:**
   ```
   dotnet restore ./server
   dotnet restore ./client
   ```

4. **Apply database migrations (if needed):**
   ```
   cd server
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   cd ..
   ```

## How to Run the Project

1. **Start the server:**
   ```
   cd server
   dotnet run
   ```
   The API will be available at `https://localhost:xxx` (or the port shown in the console).

2. **Run the client (in a new terminal):**
   ```
   cd client
   dotnet run
   ```

## Example Usage / Expected Output

The client will perform and display the following sequence:

```
=== CLIENT STARTED ===

--- GET ALL ---
Status: OK
[]

--- CREATE ---
Status: Created
{"id":1,"name":"Laptop","price":50000}

--- GET ALL ---
Status: OK
[{"id":1,"name":"Laptop","price":50000}]

--- GET BY ID ---
Status: OK
{"id":1,"name":"Laptop","price":50000}

--- UPDATE ---
Status: OK
{"id":1,"name":"Updated Laptop","price":60000}

--- DELETE ---
Status: OK

--- GET ALL ---
Status: OK
[]

=== CLIENT FINISHED ===
```

