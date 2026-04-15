using System;
using Interfaces;
using Models;
using MemoryClass;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            IRepository<Product> repo = new InMemoryRepository<Product>();

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- PRODUCT MENU ---");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Get Product by Id");
                Console.WriteLine("4. Update Product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("6. Exit");

                Console.Write("Enter choice: ");
                string input = Console.ReadLine() ?? string.Empty;;

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Id: ");
                        int id = int.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine() ?? string.Empty;

                        repo.Add(new Product { Id = id, Name = name });
                        Console.WriteLine("Product added!");
                        break;

                    case 2:
                        var products = repo.GetAll();

                        foreach (var p in products)
                        {
                            Console.WriteLine($"{p.Id} - {p.Name}");
                        }
                        break;

                    case 3:
                        Console.Write("Enter Id: ");
                        int getId = int.Parse(Console.ReadLine() ?? "0");

                        var product = repo.Get(getId);

                        if (product != null)
                            Console.WriteLine($"{product.Id} - {product.Name}");
                        else
                            Console.WriteLine("Product not found");
                        break;

                    case 4:
                        Console.Write("Enter Id: ");
                        int updateId = int.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Enter New Name: ");
                        string newName = Console.ReadLine() ?? string.Empty;

                        repo.Update(new Product { Id = updateId, Name = newName });
                        break;

                    case 5:
                        Console.Write("Enter Id: ");
                        int deleteId = int.Parse(Console.ReadLine() ?? "0");

                        repo.Delete(deleteId);
                        break;

                    case 6:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}