class Progam
{
    static void Main()
    {
        Console.Write("Enter the first name: ");
        string? firstName = Convert.ToString(Console.ReadLine());

        Console.Write("Enter the last name: ");
        string? lastName = Convert.ToString(Console.ReadLine());

        Console.Write("Enter the ZIP code: ");
        double zipCode = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an Employee ID: ");
        string? employeeId = Convert.ToString(Console.ReadLine());
        
        ValidateInput(firstName, lastName, zipCode, employeeId);
    }

    static void ValidateInput(string? firstName, string? lastName, double zipCode, string? employeeID)
    {
        bool hasError = false;
        
        if (string.IsNullOrEmpty(firstName) || firstName.Length < 2)
        {
            Console.WriteLine("\"\\\"{0}\\\"is not a valid first name. ");
            hasError = true;
        }
        
        if (string.IsNullOrEmpty(lastName))
        {
            Console.WriteLine("You must enter a last name. ");
            hasError = true;
        }

        if (!hasError)
        {
            Console.WriteLine("check inputs...");
        }
    }
}