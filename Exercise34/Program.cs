class Program
{
    static void Main()
    {
        List<string> employees = new List<string>
        {
            "John Smith",
            "Jackie Jackson",
            "Chris Jones",
            "Amanda Cullen",
            "Jeremy Goodwin"
        };
        
        Console.WriteLine($"There are {employees.Count} employees. ");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
        
        Console.WriteLine("Enter an employee name to remove: ");
        string employeeToRemove = Console.ReadLine();

        bool removed = employees.Remove(employeeToRemove);

        if (removed)
        {
            Console.WriteLine($"$There are now {employees.Count} employees: ");
            
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            } 
            {
                Console.Write($"Employee '{employeeToRemove}' has been removed from the list. ");
            }
        }
        Console.ReadLine();
    }

}