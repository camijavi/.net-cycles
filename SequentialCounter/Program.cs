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
            Console.WriteLine("Enter a positive integer number:");
            string input = Console.ReadLine();
            
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
    }
}
