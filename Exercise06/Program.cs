Console.Write("What is your age? ");
double age = Convert.ToDouble(Console.ReadLine());

Console.Write("At what age would you like to retire? ");
double desiredRetirementAge = Convert.ToDouble(Console.ReadLine());

double projectedYearsUntilRetirement = desiredRetirementAge - age;
DateTime currentTime = DateTime.Now;
int currentYear = currentTime.Year;

int projectedYearOfRetirement = currentYear + Convert.ToInt32(projectedYearsUntilRetirement);

if (projectedYearsUntilRetirement <= 0)
{
    Console.WriteLine("You can already retire.");
    Environment.Exit(0);
}

Console.WriteLine($"You have {projectedYearsUntilRetirement} years left until you can retire.");
Console.WriteLine($"It's {currentYear}, so you can retire in {projectedYearOfRetirement}");
