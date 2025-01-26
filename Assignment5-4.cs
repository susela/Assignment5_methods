namespace Assignment5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a method to display the n number Fibonacci sequence 
            //declaring a variable to save the user inputed number of Fibonacci Series
            int sequenceNumber;
            //getting the number of fibonacci sequence as user input
            Console.Write("Enter the size of you Fibanocci Series: ");

            //Validating
            while (!int.TryParse(Console.ReadLine(), out sequenceNumber) || sequenceNumber < 0)
            {
                Console.WriteLine("Invalid Input!! Enter a Valid Number: ");
            }

            //Dislpaying result
            Console.WriteLine($"The first {sequenceNumber} of Fibanocci Sequence are: ");

            //calling method to make and display the series  
            FibonacciSequence(sequenceNumber);

            Console.WriteLine("Press any Key to Continue............");
            Console.ReadKey();

        }

        //Method to make and display fibonacci sequence
        static void FibonacciSequence(int sequenceNumber)
        {
            //variables to store the fibonacci sequence
            int firstNumber = 0, secondNumber = 1, nextNumber;

            for (int i = 1; i <= sequenceNumber; i++)
            {
                Console.Write(firstNumber + " ");
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }
    }
}