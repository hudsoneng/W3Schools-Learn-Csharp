# C# Syntax — Hello World Breakdown

This document explains the basic syntax of a C# program using a classic **Hello World** example.

## Source Code

```csharp
using System;

namespace Syntax
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
Line-by-Line Explanation
Line 1 — using System
using System;
using System means that we can use classes from the System namespace.
This gives access to built-in classes like Console, Math, String, and others.

Line 2 — Blank Line
C# ignores white space. However, using multiple lines and spacing makes the code more readable.

Line 3 — namespace
namespace Syntax
namespace is used to organize your code. It acts as a container for classes and other namespaces, helping avoid naming conflicts in larger projects.

Line 4 — Curly Braces {}
{
    ...
}
The curly braces {} mark the beginning and end of a block of code.

Line 5 — class
public class Program
A class is a container for data and methods, which brings functionality to your program.
Every line of code that runs in C# must be inside a class. In this example, the class is named Program.

Line 7 — Main Method
static void Main(string[] args)
The Main method always appears in a C# program.
Any code inside its curly brackets {} will be executed when the program runs.

Line 9 — Console.WriteLine()
Console.WriteLine("Hello World!");
Console is a class from the System namespace.
The WriteLine() method is used to output/print text to the console.
In this example, it prints:

Hello World!