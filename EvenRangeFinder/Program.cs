namespace EvenRangeFinder;
// this program displays all even integers from 1 to 100 and then it shows how many even integers were found.
class Program
{
    static void Main(string[] args)
    {
        int evenCount = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                evenCount++;
            }
        }

        Console.WriteLine($"Found {evenCount} even integers.");
    }
}
