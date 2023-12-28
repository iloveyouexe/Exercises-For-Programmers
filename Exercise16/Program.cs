Console.Write("What is your age? ");
double ageOfUser = Convert.ToDouble(Console.ReadLine());

if (ageOfUser > 15)
{
    Console.WriteLine("You are old enough to legally drive. ");
}
else
{
    Console.WriteLine("You are not old enough to legally drive ");    
}