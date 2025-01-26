namespace Assignment5_6
{
    internal class Program
    {

        // Method to check if a number is prime
        public static bool IsPrime(int number)
        {
            // Handle edge cases
            if (number <= 1)
                return false;
            if (number == 2 || number == 3)
                return true;

            // Check divisibility for numbers greater than 3
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main()
        {
            Console.Write("Enter a number to check if it's prime: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (IsPrime(number))
                    Console.WriteLine($"{number} is a prime number.");
                else
                    Console.WriteLine($"{number} is not a prime number.");
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }
    }

}

