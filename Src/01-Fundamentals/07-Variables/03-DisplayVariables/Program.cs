using System;

namespace DisplayVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Example using Data Type string for display text and a variable
            /// </summary>
            string PersonName = "John";
            Console.WriteLine($"Hello {PersonName}!");

            /// <summary>
            /// Example You can also use the + character to add a variable to another variable:
            /// </summary>
            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);


            /// <summary>
            /// Example For numeric values, the + character works as a mathematical operator (notice that we use int (integer) variables here):
            /// </summary>
            int x = 5;
            int y = 6;
            Console.WriteLine(x + y); // Print the value of x + y
        }
    }
}