// three item checkout

// item 1
Console.Write("Enter the price of item 1: ");
double item01Price = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the quantity of item 1: ");
double item01Qty = Convert.ToDouble(Console.ReadLine());
double item01Total = item01Price * item01Qty;

// item 2
Console.Write("Enter the price of item 2: ");
double item02Price = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the quantity of item 2: ");
double item02Qty = Convert.ToDouble(Console.ReadLine());
double item02Total = item02Price * item02Qty;

// item 3
Console.Write("Enter the price of item 3: ");
double item03Price = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the quantity of item 3: ");
double item03Qty = Convert.ToDouble(Console.ReadLine());
double item03Total = item03Price * item03Qty;

// subtotal
double subtotal = item01Total + item02Total + item03Total;
Console.WriteLine($"Subtotal: ${subtotal}");

// sales tax
double salesTaxRate = 0.055;
double salesTax = subtotal * salesTaxRate;
Console.WriteLine($"Tax: ${salesTax}");

//  total
double total = salesTax + subtotal;
Console.WriteLine($"Total: ${total}");



