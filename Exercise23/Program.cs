Console.Write("Is the car silent when you turn the key? ");
string? isCarSilent = Convert.ToString(Console.ReadLine());

if (isCarSilent == "y")
{
    Console.Write("Are the battery terminals corroded? ");
    string? areTerminalsCorroded = Convert.ToString(Console.ReadLine());

    if (areTerminalsCorroded == "y")
    {
        Console.WriteLine("Clean terminals and try starting again.");
    } else if (areTerminalsCorroded == "n")
    {
        Console.WriteLine("Replace cables and try again.");
    }
} else if (isCarSilent == "n")
{
    
}