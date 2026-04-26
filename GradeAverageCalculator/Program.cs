namespace GradeAverageCalculator;

class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        int sum = 0;
        double average = 0.0;

        Console.Clear();
        Console.WriteLine("==========================================");
        Console.WriteLine("         GRADE AVERAGE CALCULATOR         ");
        Console.WriteLine("==========================================");

        while (true)
        {
            Console.Write("\nEnter the number of grades you want to input (or type 'x' to exit): ");
         

            string? input = Console.ReadLine()?.ToLower();

            if (input == "x") break; //exits the loop if the user enters 'x';

            if (int.TryParse(input, out n) && n > 0)
            {
                Console.WriteLine("Enter the grades:");
                for (int i = 0; i < n; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out int number) && number >= 0 && number <=100)
                    {
                        sum += number;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 0 and 100.");
                        Console.ReadLine();
                        
                    }
                }

                average = (double)sum / n;

                Console.WriteLine("\nThe average of the grades is: " + average.ToString("n2"));
            }
        }

        Console.WriteLine("\nGoodbye!\nmade by @camijavi");
    }
}

