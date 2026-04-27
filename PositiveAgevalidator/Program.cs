namespace PositiveAgevalidator;

class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
           Console.WriteLine("\nPlease input your age:");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int age))
            {
                Console.WriteLine("\nError: You must enter a valid number (no text).");
            }
            else if (age <= 0)
            {
                Console.WriteLine("\nError: Age must be greater than zero.");
            }
            else
            {
                Console.WriteLine($"\nYour age is: {age}");
                break;
            }
        }  

        Console.WriteLine("\nGoodbye!\nMade by @camijavi");
    }
}
