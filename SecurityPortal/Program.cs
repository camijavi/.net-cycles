namespace SecurityPortal;

class Program
{
    static void Main(string[] args)
    {
        string password = "camila123";
        string userInput = "";

        while(true){
            Console.Write("Please enter your password:");
            userInput = Console.ReadLine();

            if(userInput == password){
                Console.WriteLine("Access granted!");
                
            }
            else{
                Console.WriteLine("Access DENIED! Try again....");
            }
        }
 
    }
}
