    class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime SeparationDate { get; set; }
    }
    
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "John Smith", Position = "Manager", SeparationDate = DateTime.Parse("2022-01-27") },
            new Employee { Name = "Tou Xiong", Position = "Developer", SeparationDate = DateTime.Parse("2023-05-15") },
            new Employee { Name = "Michaela Michaelson", Position = "Designer", SeparationDate = DateTime.Parse("2021-12-10") },
            new Employee { Name = "Jake Jacobson", Position = "Analyst", SeparationDate = DateTime.Parse("2024-02-01") },
            new Employee { Name = "Jacquelyn Jackson", Position = "Engineer", SeparationDate = DateTime.Parse("2023-07-20") },
            new Employee { Name = "Sally Weber", Position = "Administrator", SeparationDate = DateTime.Parse("2022-08-05") }
        };
        
        Console.Write("Enter a search string: ");
        
        var searchString = Console.ReadLine();
        string? searchWords = Convert.ToString(searchString);
        
        Console.WriteLine("Results: ");
        Console.WriteLine("       Name         |      Position     | Separation Date");
        Console.WriteLine("--------------------|-------------------|----------------");
        
        var filteredEmployees = employees.Where(employee =>
        {
            return searchWords!.Any(word => employee.Name.Contains(word, StringComparison.OrdinalIgnoreCase))
                   || searchWords!.Any(word => employee.Position.Contains(word, StringComparison.OrdinalIgnoreCase))
                   || searchWords!.Any(word =>
                       employee.SeparationDate.ToString("yyyy-MM-dd")
                           .Contains(word, StringComparison.OrdinalIgnoreCase));
        });
        
        foreach (var employee in filteredEmployees)
        {
            Console.WriteLine($"{employee.Name,-19} | {employee.Position,-17} | {employee.SeparationDate:yyyy-MM-dd}");
        }
    }
}
