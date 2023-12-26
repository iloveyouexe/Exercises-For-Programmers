Console.Write("What is the principal amount? ");
double principal = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the rate? ");
double rateOfInterest = Convert.ToDouble(Console.ReadLine()) / 100;

Console.Write("What is the number of years? ");
double numberOfYears = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the number of times the interest is compounded per year? ");
double timesInterestCompoundedPerYear = Convert.ToDouble(Console.ReadLine());

double amount = principal * Math.Pow((1 + rateOfInterest / timesInterestCompoundedPerYear), timesInterestCompoundedPerYear * numberOfYears);

Console.WriteLine($"{principal:C} invested at {rateOfInterest * 100}% for {numberOfYears} years compounded {timesInterestCompoundedPerYear} times per year is {amount:C}.");