namespace Exercise24;

static class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two strings and I'll tell you if they are anagrams: ");
        Console.Write("Enter the first string: ");
        string? firstString = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string? secondString = Console.ReadLine();

        bool isAnagram = IsAnagram(firstString, secondString);

        Console.WriteLine(isAnagram ? "The strings are anagrams!" : "The strings are not anagrams.");
    }

    static bool IsAnagram(string? first, string? second)
    {
        if (first != null && second != null && first.Length != second.Length)
        {
            return false;
        }

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        if (first != null)
            foreach (char c in first)
            {
                if (!charCount.TryAdd(c, 1))
                {
                    charCount[c]++;
                }
            }

        if (second != null)
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