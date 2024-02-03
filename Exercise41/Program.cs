using System;
using System.IO;

class Program
{
    public static void Main()
    {
        string inputRelativePath = @"Inputs\input.txt";
        string outputRelativePath = @"Outputs\output.txt";
        
        // Get the full paths
        string inputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, inputRelativePath);
        string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outputRelativePath);

        try
        {
            // Read the input
            using StreamReader sr = new StreamReader(inputPath);
            var inputs = sr.ReadToEnd().Trim();
            
            // Split names based on newline character
            string[] names = inputs.Split('\n');
            
            // Calculate the total number of names
            int inputTotal = names.Length;
            
            // Write the output
            using StreamWriter sw = new StreamWriter(outputPath);
            Console.WriteLine($"Output of file located at {outputPath}. ");
            sw.WriteLine($"Total of {inputTotal} names");
            sw.WriteLine("-----------------");
            sw.WriteLine($"{inputs}");
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}