namespace Assignment5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's prime:");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                bool isPrime = IsPrime(number);
                if (isPrime)
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false; // Numbers less than 2 are not prime
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; // Divisible by a number other than 1 and itself
                }
            }

            return true; // Prime number
        }
    }