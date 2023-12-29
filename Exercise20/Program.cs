var stateTaxLookup = new Dictionary<string, double>
{
    ["Wisconsin"] = .05,
    ["Alabama"] = .04
};

Console.Write("What is the order amount? ");
double orderAmount = Convert.ToDouble(Console.ReadLine());

Console.Write("What state do you live in? ");
string? stateOfOrder = Convert.ToString(Console.ReadLine());

double tax = orderAmount * stateTaxLookup[stateOfOrder];
double finalTotal = orderAmount + tax;

Console.WriteLine($"The tax is ${tax:F2}. ");
Console.WriteLine($"The total is ${finalTotal:F2}. ");





