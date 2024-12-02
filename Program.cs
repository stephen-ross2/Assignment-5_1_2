using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

namespace Assignment_5_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positve number to add each individual character: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number > 0) // Check the "input" variable to see if it is a valid positve integer.
                                                                   // If it is, store the integer as an integer variable named "number".
            {
                int sum = CalculateSumOfDigits(number); //Call the CalulateSumOfDigits method and store the result in the "sum" variable.
                Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
            }
            else // If the input is not a valid integer, display an error message.
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        public static int CalculateSumOfDigits(int num)
        {
            int sum = 0; //sets the initial value of the sum to 0


            // Iterate through each character in the string
            foreach (char digitChar in num.ToString())
            {
                // Convert the character back to an integer and add to the sum
                sum += int.Parse(digitChar.ToString());
            }

            return sum;
        }
    }
}







