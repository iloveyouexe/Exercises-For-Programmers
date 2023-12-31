Console.Write("Is the car silent when you turn the key? ");
string? isCarSilent = Convert.ToString(Console.ReadLine());

if (isCarSilent == "y")
{
    Console.Write("Are the battery terminals corroded? ");
    string? areTerminalsCorroded = Convert.ToString(Console.ReadLine());

    if (areTerminalsCorroded == "y")
    {
        Console.WriteLine("Clean terminals and try starting again.");
        Environment.Exit(0);
    } else if (areTerminalsCorroded == "n")
    {
        Console.WriteLine("Replace cables and try again.");
        Environment.Exit(0);
    }
} else if (isCarSilent == "n")
{
    Console.Write("Does the car make a clicking noise? ");
    string? isCarClicking = Convert.ToString(Console.ReadLine());

    if (isCarClicking == "y")
    {
        Console.WriteLine("Replace the battery.");
        Environment.Exit(0);
    } else if (isCarClicking == "n")
    {
        Console.Write("Does the car crank up but fail to start? ");
        string? isEngineTurning = Convert.ToString(Console.ReadLine());

        if (isEngineTurning == "y")
        {
            Console.WriteLine("Check spark plug connections.");
            Environment.Exit(0);
        } else if (isEngineTurning == "n")
        {
            Console.Write("Does the engine start and then die? ");
            string? isEngineStartingThenDying = Convert.ToString(Console.ReadLine());

            if (isEngineStartingThenDying == "y")
            {
                Console.Write("Does your car have fuel injection? ");
                string? isFuelInjected = Convert.ToString(Console.ReadLine());

                if (isFuelInjected == "y")
                {
                    Console.WriteLine("Get it in for service.");
                    Environment.Exit(0);
                } else if (isFuelInjected == "n")
                {
                    Console.WriteLine("Check to ensure the choke is opening and closing.");
                    Environment.Exit(0);
                }
            }
        }
    }
}