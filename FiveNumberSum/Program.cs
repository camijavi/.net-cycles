namespace FiveNumberSum;

class Program
{
    static void Main(string[] args)
    {
       int sum = 0;
       
       Console.WriteLine("Enter 5 numbers:");
       for (int i = 0; i < 5; i++){
        if (int.TryParse(Console.ReadLine(), out int number)){
        sum += number;
        }else{
            Console.WriteLine("Invalid input. Please try again.");
            i--;
        }
       }
        Console.WriteLine("The sum of the numbers is: " + sum);
    }
}
