namespace SumEvenToN;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;


        Console.WriteLine("Enter an even number:");
        if (int.TryParse(Console.ReadLine(), out int evenNumber))
        {
            for (int i = 1; i <= evenNumber; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
        }
        
        Console.WriteLine($"Sum of even numbers: {sum}");
    }
}
