namespace RegressiveCountdown;

class Program
{
    static void Main(string[] args)
    {
        int num = 0;

        Console.WriteLine("Enter a number to count down from:");

        if (int.TryParse(Console.ReadLine(), out num) && num > 0)
        {
            Console.Clear();
            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        else { 
            Console.WriteLine("Please enter a valid positive integer.");
        }
    }
}
