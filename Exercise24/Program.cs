class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two strings and I'll tell you if they are anagrams: ");
        Console.Write("Enter the first string: ");
        string firstString = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string secondString = Console.ReadLine();

        bool isAnagram = IsAnagram(firstString, secondString);

        if (isAnagram)
        {
            Console.WriteLine("The strings are anagrams!");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
    }

    static bool IsAnagram(string first, string second)
    {
        if (first.Length != second.Length)
        {
            return false;
        }

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in first)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        
        foreach (char c in second)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]--;

                if (charCount[c] < 0)
                {
                    return false;
                }
            }
            else
            {
                return false; 
            }
        }
        
        foreach (var pair in charCount)
        {
            if (pair.Value != 0)
            {
                return false; 
            }
        }

        return true; 
    }
}
