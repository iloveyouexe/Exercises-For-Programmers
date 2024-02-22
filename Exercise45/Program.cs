using System;
using System.IO;
using static System.StringComparison;

class Program
{
    static void Main()
    {
        //start
        Console.WriteLine("Enter the input file name:");
        string inputFile = Console.ReadLine();

        Console.WriteLine("Enter the output file name:");
        string outputFile = Console.ReadLine();
        
        string content = File.ReadAllText(inputFile);
        
        int replacements = 0;
        string modifiedContent = content.Replace(oldValue: "utilize",
            newValue: "use",
            ignoreCase: OrdinalIgnoreCase,
            culture: out replacements);
        
        File.WriteAllText(outputFile, modifiedContent);

        Console.WriteLine($"File has been modified and saved as {outputFile}");
        Console.WriteLine($"Number of replacements: {replacements}");
    }
}