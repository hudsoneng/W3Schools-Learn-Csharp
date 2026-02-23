/// <summary>
/// Line 1: using System means that we can use classes from the System namespace.
/// </summary>
using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

/// <summary>
/// Line 2: A blank line. C# ignores white space. However, multiple lines makes the code more readable.
/// </summary


/// <summary>
/// Line 3: namespace is used to organize your code, and it is a container for classes and other namespaces.
/// </summary>
namespace Syntax
{
    /// <summary>
    /// Line 4: The curly braces {} marks the beginning and the end of a block of code.
    /// </summary>


    /// <summary>
    /// Line 5: class is a container for data and methods, which brings functionality to your program.Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Line 7: Another thing that always appear in a C# program is the Main method. Any code inside its curly brackets {} will be executed. You don't have to understand the keywords before and after Main. You will get to know them bit by bit while reading this tutorial.
        /// </summary>
        static void Main(string[] args)
        {
            /// <summary>
            /// Line 9: Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example, it will output "Hello World!".
            /// </summary>
            Console.WriteLine("Hello World!");
        }
    }
}