## Overview

This project demonstrates the implementation of a generic in-memory repository using C# generics and interfaces, following the Repository Pattern. The solution provides a reusable, type-safe way to perform CRUD (Create, Read, Update, Delete) operations on any entity type, with a simple console UI to showcase its usage.

## Key Features

- Generic repository interface (`IRepository<T>`) for CRUD operations
- In-memory storage (no external database required)
- Type constraints for safe and flexible usage
- Example entity (e.g., `Product` or `Student`)
- Console-based user interface for demonstration

## Tech Stack

- **Language:** C#
- **Framework:** .NET (Console Application)
- **Core Concepts:** Generics, Interfaces, Repository Pattern

## Project Structure

```
task-8/
│
├── Class/
│   └── InMemoryRepo.cs         # Generic repository implementation
├── Interfaces/
│   └── IRepository.cs          # Repository interface definition
├── Models/
│   └── Product.cs              # Example entity (e.g., Product or Student)
├── Program.cs                  # Console UI and entry point
├── task-8.csproj               # Project file
└── README.md                   # Project documentation
```

## Setup Instructions

1. **Prerequisites:**
   - [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)

2. **Clone the repository:**
   ```
   git clone <repository-url>
   cd task-8
   ```

3. **Restore dependencies:**
   ```
   dotnet restore
   ```

## How to Run the Project

From the task-8 directory, execute:

```
dotnet run
```

This will build and launch the console application.

## Example Usage / Expected Output

The console UI allows you to:

- Add new entities (e.g., products)
- View all entities
- Get a product by ID
- Update existing entities
- Delete entities by ID

**Output:**
```
--- PRODUCT MENU ---
1. Add Product
2. View All Products
3. Get Product by Id
4. Update Product
5. Delete Product
6. Exit
Enter choice: 1
Enter Id: 101
Enter Name: Apple
Product added!

--- PRODUCT MENU ---
1. Add Product
2. View All Products
3. Get Product by Id
4. Update Product
5. Delete Product
6. Exit
Enter choice: 2
101 - Apple

--- PRODUCT MENU ---
1. Add Product
2. View All Products
3. Get Product by Id
4. Update Product
5. Delete Product
6. Exit
Enter choice: 3
Enter Id: 101
101 - Apple

--- PRODUCT MENU ---
1. Add Product
2. View All Products
3. Get Product by Id
4. Update Product
5. Delete Product
6. Exit
Enter choice: 4
Enter Id: 101
Enter New Name: Green Apple

--- PRODUCT MENU ---
1. Add Product
2. View All Products
3. Get Product by Id
4. Update Product
5. Delete Product
6. Exit
Enter choice: 2
101 - Green Apple

--- PRODUCT MENU ---
1. Add Product
2. View All Products
3. Get Product by Id
4. Update Product
5. Delete Product
6. Exit
Enter choice: 5
Enter Id: 101

--- PRODUCT MENU ---
1. Add Product
2. View All Products
3. Get Product by Id
4. Update Product
5. Delete Product
6. Exit
Enter choice: 2
(no output, as the list is empty)

--- PRODUCT MENU ---
1. Add Product
2. View All Products
3. Get Product by Id
4. Update Product
5. Delete Product
6. Exit
Enter choice: 3
Enter Id: 999
Product not found

--- PRODUCT MENU ---
1. Add Product
2. View All Products
3. Get Product by Id
4. Update Product
5. Delete Product
6. Exit
Enter choice: 7
Invalid choice!

--- PRODUCT MENU ---
1. Add Product
2. View All Products
3. Get Product by Id
4. Update Product
5. Delete Product
6. Exit
Enter choice: 6
```
