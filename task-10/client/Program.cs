using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

class Program
{
    static HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        client.BaseAddress = new Uri("http://localhost:5167/"); 

        Console.WriteLine("=== CLIENT STARTED ===\n");

        await GetAll();
        await Create();
        await GetAll();
        await GetById(1);
        await Update(1);
        await Delete(1);
        await GetAll();

        Console.WriteLine("\n=== CLIENT FINISHED ===");
    }

    // ================= GET ALL =================
    static async Task GetAll()
    {
        Console.WriteLine("\n--- GET ALL ---");

        var response = await client.GetAsync("api/product");

        var content = await response.Content.ReadAsStringAsync();

        Console.WriteLine($"Status: {response.StatusCode}");
        Console.WriteLine(content);
    }

    // ================= GET BY ID =================
    static async Task GetById(int id)
    {
        Console.WriteLine("\n--- GET BY ID ---");

        var response = await client.GetAsync($"api/product/{id}");

        var content = await response.Content.ReadAsStringAsync();

        Console.WriteLine($"Status: {response.StatusCode}");
        Console.WriteLine(content);
    }

    // ================= CREATE =================
    static async Task Create()
    {
        Console.WriteLine("\n--- CREATE ---");

        var product = new
        {
            name = "Laptop",
            price = 50000
        };

        var json = JsonSerializer.Serialize(product);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PostAsync("api/product", content);

        var result = await response.Content.ReadAsStringAsync();

        Console.WriteLine($"Status: {response.StatusCode}");
        Console.WriteLine(result);
    }

    // ================= UPDATE =================
    static async Task Update(int id)
    {
        Console.WriteLine("\n--- UPDATE ---");

        var product = new
        {
            id = id,
            name = "Updated Laptop",
            price = 60000
        };

        var json = JsonSerializer.Serialize(product);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PutAsync("api/product", content);

        var result = await response.Content.ReadAsStringAsync();

        Console.WriteLine($"Status: {response.StatusCode}");
        Console.WriteLine(result);
    }

    // ================= DELETE =================
    static async Task Delete(int id)
    {
        Console.WriteLine("\n--- DELETE ---");

        var response = await client.DeleteAsync($"api/product/{id}");

        Console.WriteLine($"Status: {response.StatusCode}");
    }
}