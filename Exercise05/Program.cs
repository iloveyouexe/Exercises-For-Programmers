Console.Write("What is the first number? ");
double number01 = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the second number? ");
double number02 = Convert.ToDouble(Console.ReadLine());

double sum = number01 + number02;
double difference = number01 - number02;
double product = number01 * number02;
double quotient = number01 / number02;

Console.WriteLine($"{number01} + {number02} = {sum}");
Console.WriteLine($"{number01} - {number02} = {difference}");
Console.WriteLine($"{number01} * {number02} = {product}");
Console.WriteLine($"{number01} / {number02} = {quotient}");
