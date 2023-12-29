Console.Write("Enter the first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the third number: ");
double thirdNumber = Convert.ToDouble(Console.ReadLine());

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.WriteLine($"The largest number is {firstNumber}.");
    Environment.Exit(0);
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    Console.WriteLine($"The largest number is {secondNumber}.");
    Environment.Exit(0);
}
Console.WriteLine($"The largest number is {thirdNumber}.");