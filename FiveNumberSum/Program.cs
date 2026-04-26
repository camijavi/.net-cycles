namespace FiveNumberSum;

class Program
{
    static void Main(string[] args)
    {
       int sum = 0;
       
       Console.WriteLine("Enter a number:");
       for (int i = 0; i < 5; i++){
        int number = int.Parse(Console.ReadLine());
        sum += number;
       }

        Console.WriteLine("The sum of the numbers is: " + sum);
    }
}
