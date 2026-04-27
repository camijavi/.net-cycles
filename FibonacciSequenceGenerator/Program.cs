namespace FibonacciSequenceGenerator;

class Program
{
    static void Main(string[] args)
    {
        long a = 0, b = 1, auxiliar;
        
        Console.WriteLine("==========================================");
        Console.WriteLine("       FIBONACCI SEQUENCE GENERATOR       ");
        Console.WriteLine("==========================================");
        int n;
        while (true)
        {
            Console.Write("Enter how many Fibonacci numbers to generate: ");
            if (int.TryParse(Console.ReadLine(), out n) && n >= 0)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a);
            auxiliar = a;
            a = b;
            b = auxiliar + b;
        }
    }
}
