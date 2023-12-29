using System.Globalization;

Console.Write("Please enter the number of the month: ");
int numberOfMonth = Convert.ToInt32(Console.ReadLine());

//CultureInfo.CurrentCulture = new CultureInfo("es-ES");

string nameOfMonth = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(numberOfMonth);

Console.WriteLine($"The name of the month is {nameOfMonth}. ");