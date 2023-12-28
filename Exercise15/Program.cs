Console.Write("What is the password? ");
string password = Convert.ToString(Console.ReadLine());

if (password == "abc$123")
{
    Console.WriteLine("Welcome! ");
}
else
{  
    Console.WriteLine("I don't know you. ");
}
