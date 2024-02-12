using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the input file name:");
        string inputFile = Console.ReadLine();

        Console.WriteLine("Enter the output file name:");
        string outputFile = Console.ReadLine();
        
        string content = File.ReadAllText(inputFile);
        
        int replacements = 0;
        string modifiedContent = content.Replace("utilize", "use", StringComparison.OrdinalIgnoreCase, out replacements);
        
        File.WriteAllText(outputFile, modifiedContent);

        Console.WriteLine($"File has been modified and saved as {outputFile}");
        Console.WriteLine($"Number of replacements: {replacements}");
    }
}