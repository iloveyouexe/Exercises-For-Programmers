using System;
using System.IO;

class Program
{
    public static void Main()
    {
        string inputRelativePath = @"Inputs\input.txt";
        string outputRelativePath = @"Outputs\output.txt";
        
        string inputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, inputRelativePath);
        string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outputRelativePath);
        
        try
        {
            // Read the input
            using StreamReader sr = new StreamReader(inputPath);
            var inputData = sr.ReadToEnd().Trim();
            
            // Split lines based on newline character
            string[] lines = inputData.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            
            // Write the output
            using StreamWriter sw = new StreamWriter(outputPath);
            sw.WriteLine("Last".PadRight(15) + "First".PadRight(15) + "Salary");
            sw.WriteLine("------------------------------------");
            
            foreach (var line in lines)
            {
                // Split each line into parts based on comma
                string[] parts = line.Split(',');
                
                if (parts.Length == 3)
                {
                    string lastName = parts[0].Trim();
                    string firstName = parts[1].Trim();
                    string salary = parts[2].Trim();
                    
                    // Write formatted output
                    sw.WriteLine($"{lastName.PadRight(15)}{firstName.PadRight(15)}{salary}");
                }
            }
            
            Console.WriteLine($"Output written to file located at {outputPath}. ");
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}