namespace Assignment5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to calculate the sum of elements in an array using methods. 

            //Getting the array size  as user input
            Console.WriteLine("Enter the size of an array: ");
            int size = 0; //declaring a variable to store the array size give by the user

            //Validating the user input
            while (!int.TryParse(Console.ReadLine(), out size) || size < 0)
            {
                Console.WriteLine("Invalid Input!! Enter a Positive Integer: ");
            }

            //Declaring an array
            int[] numbers = new int[size];

            // Getting user input - array elements 
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.Write($"Element {i + 1}: ");
                }
            }

            //declaring a variable to save the sum of the array elements
            //and calculating the sum of elements in the array using method
            int totalSum = CalculateSum(numbers);

            //Displaying the result
            Console.WriteLine($"Total Sum : {totalSum}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        //method to calculate the sum of the elements
        static int CalculateSum(int[] numbers)
        {
            int sum = 0; // declaring the sum of the elements to zero

            //loop to go to each number in the array
            foreach (int number in numbers)
            {
                sum += number; // add each number and save to the sum
            }
            return sum;
        }

    }
}