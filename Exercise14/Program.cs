Console.Write("What is the order amount? ");
double orderAmount = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the state? ");
string stateOfOrder = Convert.ToString(Console.ReadLine());

double wisconsinTax = 0.55;
double endTotal = 0;

if (stateOfOrder == "WI")
{
    endTotal = orderAmount + wisconsinTax;
    
    Console.WriteLine($"The subtotal is ${orderAmount:F2}. ");
    Console.WriteLine($"The tax is ${wisconsinTax:F2}. ");
    Console.Write($"The total is ${endTotal:F2}. ");
}
else
{
    endTotal = orderAmount;
    Console.Write($"The total is ${endTotal:F2}. ");
}

