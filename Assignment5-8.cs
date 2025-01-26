namespace Assignment5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the range from the user
            Console.Write("Enter the start of the range: ");
            int start;
            while (!int.TryParse(Console.ReadLine(), out start))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }

            Console.Write("Enter the end of the range: ");
            int end;
            while (!int.TryParse(Console.ReadLine(), out end) || end < start)
            {
                Console.WriteLine("Invalid input. End of the range should be greater than or equal to the start.");
            }

            Console.WriteLine("Do you want to print even or odd numbers? (Enter 'even' or 'odd')");
            string choice = Console.ReadLine()?.ToLower();

            if (choice == "even")
            {
                Console.WriteLine("Even numbers in the range:");
                PrintEvenNumbers(start, end);
            }
            else if (choice == "odd")
            {
                Console.WriteLine("Odd numbers in the range:");
                PrintOddNumbers(start, end);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'even' or 'odd'.");
            }
        }

        // Recursive method to print even numbers
        static void PrintEvenNumbers(int current, int end)
        {
            if (current > end)
            {
                return; // Base case: When current exceeds the end of the range, stop recursion
            }

            if (current % 2 == 0)
            {
                Console.WriteLine(current);
            }

            PrintEvenNumbers(current + 1, end); // Move to the next number
        }

        // Recursive method to print odd numbers
        static void PrintOddNumbers(int current, int end)
        {
            if (current > end)
            {
                return; // Base case: When current exceeds the end of the range, stop recursion
            }

            if (current % 2 != 0)
            {
                Console.WriteLine(current);
            }

            PrintOddNumbers(current + 1, end); // Move to the next number
        }
    }
}

