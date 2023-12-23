Console.Write("How many people? ");
double numberOfPeople = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas do you have? ");
double numberOfPizzas = Convert.ToDouble(Console.ReadLine());

double numberOfPizzasPerPerson = Math.Ceiling(numberOfPizzas / numberOfPeople);
double remainingSlices = Math.Ceiling(numberOfPizzas - numberOfPizzasPerPerson);

Console.WriteLine($"{numberOfPeople} people with {numberOfPizzas} pizzas. ");
Console.WriteLine($"Each person gets {numberOfPizzasPerPerson} pieces of pizza." );
Console.Write($"There are {remainingSlices} leftover pieces.");