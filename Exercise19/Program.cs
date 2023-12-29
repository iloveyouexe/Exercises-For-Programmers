Console.Write("What is your height in inches? ");
double height = Convert.ToDouble(Console.ReadLine());
Console.Write("What is your weight in pounds? ");
double weight = Convert.ToDouble(Console.ReadLine());

double bmi = (weight / (height * height)) * 703;

if (bmi > 18.5 && bmi < 25)
{
    Console.WriteLine($"Your BMI is {bmi:F1}.");
    Console.WriteLine("You are within the ideal weight range.");
}
else if (bmi >= 25)
{
    Console.WriteLine($"Your BMI is {bmi:F1}.");
    Console.WriteLine("You are overweight. You should see your doctor. ");
}
else
{
    Console.WriteLine($"Your BMI is {bmi:F1}.");
    Console.WriteLine("You are underweight. You should see your doctor. ");
}

