//C = ( F − 32) × 5 / 9
//F = ( C × 9 / 5) + 32

Console.Write("Press C to convert from Fahrenheit to Celsius or Press F to convert from Celsius to Fahrenheit. ");

string? celsiusOrFahrenheit = Convert.ToString(Console.ReadLine());

if (celsiusOrFahrenheit == "C")
{
    // do something
    Console.Write("Please enter the temperature in Fahrenheit: ");
    double temperatureInFahrenheit = Convert.ToDouble(Console.ReadLine());
    double temperatureInCelsius = (5 * (temperatureInFahrenheit - 32)) / 9;
    
    Console.WriteLine($"The temperature in Celsius is {temperatureInCelsius}. ");

}
else if (celsiusOrFahrenheit == "F")
{
    Console.Write("Please enter the temperature in Celsius: ");
    double temperatureInCelsius = Convert.ToDouble(Console.ReadLine());
    double temperatureInFahrenheit = ((9 * temperatureInCelsius) / 5) + 32;
    
    Console.WriteLine($"The temperature in Fahrenheit is {temperatureInFahrenheit}. ");
}

;


