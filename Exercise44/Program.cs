using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        List<Product?> products = LoadProductsFromJson("Data/data.json");

        while (true)
        {
            string? productName = PromptForProductName();
            SearchAndPrintProductDetails(products, productName);

            if (!AskForAnotherSearch())
                break;
        }
    }

    static List<Product?> LoadProductsFromJson(string jsonFilePath)
    {
        string jsonData = File.ReadAllText(jsonFilePath);
        ProductList productList = JsonSerializer.Deserialize<ProductList>(jsonData);
        return productList.Products;
    }

    static string? PromptForProductName()
    {
        Console.WriteLine("What is the product name? ");
        return Console.ReadLine();
    }

    static void SearchAndPrintProductDetails(List<Product?> products, string? productName)
    {
        Product? product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

        if (product != null)
        {
            PrintProductDetails(product);
        }
        else
        {
            Console.WriteLine("Sorry, that product was not found in our inventory.");
        }
    }

    static void PrintProductDetails(Product? product)
    {
        Console.WriteLine($"Name: {product.Name}");
        Console.WriteLine($"Price: ${product.Price:F2}");
        Console.WriteLine($"Quantity on hand: {product.Quantity}");
    }

    static bool AskForAnotherSearch()
    {
        Console.WriteLine("Do you want to search for another product? (yes/no)");
        string choice = Console.ReadLine().ToLower();
        return choice == "yes";
    }
}

class ProductList
{
    public List<Product?> Products { get; set; }
}

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}