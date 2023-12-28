Console.Write("What is your weight in pounds? ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.Write("What is your gender? ");
string gender = Convert.ToString(Console.ReadLine());

Console.Write("What is the number of drinks you've consumed in ounces? ");
double numberOfDrinks = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the amount of alcohol by volume of the drinks consumed? ");
double abvOfDrinks = Convert.ToDouble(Console.ReadLine());

Console.Write("How long has it been since your last drink in hours? ");
double hoursSinceLastDrinks = Convert.ToDouble(Console.ReadLine());

double r = (gender == "male") ? 0.73 : 0.66;
double bloodAlcoholContent = (numberOfDrinks * 5.14 / (weight * r)) - 0.015 * hoursSinceLastDrinks;

if (bloodAlcoholContent > 0.08)
{
    Console.WriteLine("You're drunk sir! ");
}

else
{
    Console.WriteLine("You can still drink more beer. ");
}

