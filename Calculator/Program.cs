using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {

        bool isAppOn = true;

        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("---------------------------");

        while (isAppOn)
        {
           
            double result = 0;

            Console.WriteLine("Enter a number, then type any key");
            var num1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (string.IsNullOrWhiteSpace(num1) || !double.TryParse(num1, out cleanNum1))
            {
                Console.WriteLine("Please, enter a valid number");
                num1 = Console.ReadLine();
            }

            Console.WriteLine("Enter another number, then press any key");
            var num2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (string.IsNullOrWhiteSpace(num2) || !double.TryParse(num2, out cleanNum2))
            {
                Console.WriteLine("Please, enter a valid number");
                num2 = Console.ReadLine();
            }

            Console.WriteLine(@$"Select one of the following operations:
A - Add
S - Substract
M - Multiply
D - Division
");

            var operation = Console.ReadLine();
            if (operation == null || !Regex.IsMatch(operation, "[a|s|m|d]"))
            {
                Console.WriteLine("Error, unrecognized input, try again!");
            }
            else
            {
                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, operation);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
            }

            Console.WriteLine("------------------------\n");

            // Wait for the user to respond before closing.
            Console.Write("Press 'q' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "q") isAppOn = false;

            Console.WriteLine("\n"); // Friendly linespacing.
            Console.Clear(); 
        }
        return;
    }
 }  




