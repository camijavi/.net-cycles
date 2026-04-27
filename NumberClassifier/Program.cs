namespace NumberClassifier;

class Program
{
    static void Main(string[] args)
    {

        int counter1 = 0; // positive
        int counter2 = 0; // zero
        int counter3 = 0; // negative
       

       Console.WriteLine("Enter 10 numbers to classify:");
        for (int i = 0; i <10; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
              if (number > 0)
                {
                    counter1++;
                }
                else if (number == 0)
                {
                    counter2++;
                }
                else
                {
                    counter3++;
                }
            }
             else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");

            }
          }

        Console.WriteLine($"Positive numbers: {counter1}");
        Console.WriteLine($"Zero numbers: {counter2}");
        Console.WriteLine($"Negative numbers: {counter3}");

    }
}
