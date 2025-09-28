using System;

namespace DivisionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            string input2 = Console.ReadLine();

            DivideStrings(input1, input2);

        }
        static void DivideStrings(string str1, string str2)
        {
            try
            {
                int num1 = int.Parse(str1);
                int num2 = int.Parse(str2);

                int result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input is not a valid integer.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error occurred: {ex.Message}");
            }
        }
    }
}