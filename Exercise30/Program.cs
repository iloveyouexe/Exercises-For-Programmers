class Program
{
    static void Main()
    {
        for (int i = 0; i <= 12; i++)
        {
            for (int j = 0; j <= 12; j++)
            {
                int product = i * j;
                Console.WriteLine($"{i} x {j} = {product, -4} ");
            }
        }
    }
}