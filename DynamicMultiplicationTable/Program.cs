namespace DynamicMultiplicationTable;

class Program
{
    static void Main(string[] args)
    {
        int userInput, result;

        Console.WriteLine("Enter a number to see its multiplication table up to 10:");
        
        if (int.TryParse(Console.ReadLine(), out userInput))
        {
             for (int i = 1; i <= 10; i++)
             {
                result = userInput * i;
                Console.WriteLine($"{userInput} x {i} = {result}"); 
             }
        }
        else 
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
