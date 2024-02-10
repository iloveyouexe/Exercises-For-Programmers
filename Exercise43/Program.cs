using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a site name: ");
        var siteName = Console.ReadLine();
        
        Console.WriteLine("Enter the author name: ");
        var siteAuthor = Console.ReadLine();
        
        bool javascriptFolder = AskForFolder("JavaScript");
        
        bool cssFolder = AskForFolder("CSS");
        
        string siteDirectory = Path.Combine(Directory.GetCurrentDirectory(), siteName);
        Directory.CreateDirectory(siteDirectory);
        Console.WriteLine($"Created {siteDirectory}");
        
        string indexFilePath = Path.Combine(siteDirectory, "index.html");
        File.WriteAllText(indexFilePath, $"<title>{siteName}</title>\n<meta author=\"{siteAuthor}\">");
        Console.WriteLine($"Created {indexFilePath}");
        
        if (javascriptFolder)
        {
            string jsDirectory = Path.Combine(siteDirectory, "js");
            Directory.CreateDirectory(jsDirectory);
            Console.WriteLine($"Created {jsDirectory}");
        }
        
        if (cssFolder)
        {
            string cssDirectory = Path.Combine(siteDirectory, "css");
            Directory.CreateDirectory(cssDirectory);
            Console.WriteLine($"Created {cssDirectory}");
        }
    }

    static bool AskForFolder(string fileType)
    {
        Console.WriteLine($"Do you want a folder for {fileType}? (y / n)");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "y")
            return true;
        else if (userInput == "n")
            return false;
        else
        {
            Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            return AskForFolder(fileType); // Ask again recursively
        }
    }
}
