namespace Assignment5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //display the individual digits of a given number using recursion.  
            // Get user input
            Console.Write("Enter a number: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            Console.WriteLine("The digits of the number are:");
            DisplayDigits(number);
        }

        // Recursive method to display the digits of the number
        static void DisplayDigits(int number)
        {
            if (number == 0)
            {
                return; // Base case: When the number becomes 0, stop recursion
            }

            // Display digits in reverse order during the recursion
            DisplayDigits(number / 10);

            // Display the last digit of the current number
            Console.WriteLine(number % 10);
        }
    }
}
