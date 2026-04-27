namespace PositiveAgevalidator;

class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
           Console.WriteLine("Please input your age:");


            string input = Console.ReadLine();

            if (!int.TryParse(input, out int age))
            {
                Console.WriteLine("Error: You must enter a valid number (no text).");
            }
            else if (age <= 0)
            {
                Console.WriteLine("Error: Age must be greater than zero.");
            }
            else
            {
                Console.WriteLine($"Your age is: {age}");
                break;
            }
        }  

        Console.WriteLine("\nGoodbye!\n Made by @camijavi");
    }
}
