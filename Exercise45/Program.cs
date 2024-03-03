using System;
using System.IO;
using System.Text.RegularExpressions; // Include this namespace for Regex

class Program
{
    static void Main()
    {
        // Start
        Console.WriteLine("Enter the input file name:");
        string inputFile = Console.ReadLine();

        Console.WriteLine("Enter the output file name:");
        string outputFile = Console.ReadLine();
        
        string content = File.ReadAllText(inputFile);

        // Use Regex for case-insensitive replacement
        string pattern = "utilize";
        string replacement = "use";
        string modifiedContent = Regex.Replace(content, pattern, replacement, RegexOptions.IgnoreCase);
        
        // Count replacements by comparing original and modified content
        int replacements = (content.Length - modifiedContent.Length) / (pattern.Length - replacement.Length);

        File.WriteAllText(outputFile, modifiedContent);

        Console.WriteLine($"File has been modified and saved as {outputFile}");
        Console.WriteLine($"Number of replacements: {replacements}");
    }
}