Console.Write("Enter the principal: ");
double principal = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the rate of interest: ");
double rateOfInterest = Convert.ToDouble(Console.ReadLine()) / 100;

Console.Write("Enter the number of years: ");
double numberOfYears = Convert.ToDouble(Console.ReadLine());

double investmentValue = principal * (1 + rateOfInterest * numberOfYears);

Console.WriteLine($"After {numberOfYears} years at {rateOfInterest * 100}%, the investment will be worth ${investmentValue:F2}. ");