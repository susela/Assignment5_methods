namespace Assignment5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a method to swap the values of two integer numbers. 

            //declaring two variables store user inputs
            int firstNumber, secondNumber;

            //getting first number from user as input
            Console.Write("Enter first number: ");

            //Validating first number
            while (!int.TryParse(System.Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Invalid Input!! Enter a number: ");
            }

            //getting second number from user as input
            Console.Write("Enter Second Number: ");

            //Validating second number
            while (!int.TryParse(System.Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Invalid Input!! Enter a number: ");
            }

            //Displaying user input
            Console.WriteLine("---------------Before Swapping------------");
            Console.WriteLine($"First Number: {firstNumber}, Second Number: {secondNumber}");

            //Calling Method Swap
            Swap(ref firstNumber, ref secondNumber);

            //Display Swapped values
            Console.WriteLine("------------------After Swapping----------------");
            Console.WriteLine($"First Number: {firstNumber}, Second Number: {secondNumber}");


            Console.WriteLine("Press any key to exit...........");
            Console.ReadKey();

        }

        //method to swap numbers
        static void Swap(ref int firstNumber, ref int secondNumber)
        {
            // declaring a temporary variable to store firstnumber 
            int tempVaribale = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempVaribale;
        }
    }
}