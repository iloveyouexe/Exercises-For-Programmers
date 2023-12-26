Console.Write("How many euros are you exchanging? ");
double euroAmount = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the exchange rate? ");
double exchangeRate = Convert.ToDouble(Console.ReadLine());

double usdAmount = euroAmount * exchangeRate;
usdAmount = Math.Round(usdAmount / 100, 2); 

Console.WriteLine($"{euroAmount} euros at an exchange rate of {exchangeRate} is {usdAmount:F2} U.S. dollars.");