namespace RangeConstraintValidator;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Write("Please enter a number between 1 and 10:");
            
            int num = Convert.ToInt32(Console.ReadLine());

            if (!(num >= 1 && num <= 10))
            {
                Console.WriteLine("Error: Number must be between 1 and 10.\n");
            }
            else
            {
                Console.WriteLine($"\nYou entered a valid number: {num}");
                break;
            }
        }
    }
}
