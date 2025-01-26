namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a method to input a string and count number of spaces are in the string 

            //getting input from user
            Console.WriteLine("Enter a string: ");
            string sentence = Console.ReadLine(); //declaring a variable to store the user input

            //calling count method
            int spaceCount = Count(sentence);

            //displaying the result
            Console.WriteLine($"The number of spaces in the string: {spaceCount}");


            Console.WriteLine("Press any key to continuee....");
            Console.ReadKey();


            //Method to count the space in the sentence
            static int Count(string sentence)
            {
                //declaraing a variable to store counted spaces in the string
                int count = 0;

                //loop to iterate through each characters in the string
                foreach (char c in sentence)
                {
                    //loop to check for space

                    if (c == ' ')
                    {
                        count++; //to add the count if spaces
                    }
                }
                //return the value
                return count;

            }

        }
    }
}

