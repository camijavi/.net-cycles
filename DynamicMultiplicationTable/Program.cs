namespace DynamicMultiplicationTable;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("       DYNAMIC MULTIPLICATION TABLE       ");
            Console.WriteLine("==========================================");
            Console.Write("\nEnter a number (or type '0' to exit): ");

            string? input = Console.ReadLine();
            
            if (input == "0") break; //exits the loop if the user enters '0' 

            if (int.TryParse(input, out int num)) //validate if the input is a valid number
            {
                Console.WriteLine($"\nMultiplication Table for: {num}");
                Console.WriteLine("------------------------------------------"); // decoration 

                for (int i = 1; i <= 10; i++)
                {
                     
                    Console.WriteLine($"{num} x {i} = {num * i}");  // formula for multiplication
                }

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("\nPress any key to try another..."); 
                Console.ReadKey();
            }
            
            else
            {
                Console.WriteLine("\n[!] Invalid input. Please enter a valid number.");
                Thread.Sleep(1500);
            }
        }

        Console.WriteLine("\nGoodbye!");
    }
}
