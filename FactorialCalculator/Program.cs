namespace FactorialCalculator;

class Program
{
    static void Main(string[] args)
    {
        long n = 0;
        long result = 1;

        Console.Clear();
        Console.WriteLine("==========================================");
        Console.WriteLine("       FACTORIAL CALCULATOR       ");
        Console.WriteLine("==========================================");
        Console.Write("\nEnter a number: ");

        if (long.TryParse(Console.ReadLine(), out n) && n >= 0)
        {
            for (long i = 1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine($"The factorial of {n} is: {result:N0}");
        }


        Console.WriteLine("\nGoodbye!\nMade by @camijavi")
    }
}
