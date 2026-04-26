namespace SequentialCounter;

// user enters a positive integer number N
// print all integers from 1 to N
// validate if n is greater than 0 before execute the program

class Program
{
    static void Main(string[] args)
    {
        int n;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("          SEQUENTIAL COUNTER          ");
            Console.WriteLine("==========================================");
            Console.Write("\nEnter a positive integer number (or type 'exit' to exit): ");
           
            string input = Console.ReadLine().ToLower();
            
            if (input == "exit") break;

            if (int.TryParse(input, out n) && n > 0)
            {
                break;
            }
            
            Console.WriteLine("Invalid input. Please enter a number greater than 0.");
        }

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nGoodbye!\nmade by @camijavi");
    }
}
