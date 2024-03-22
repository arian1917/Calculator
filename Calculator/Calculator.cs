using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Calculator
{
    public static double DoOperation(double x, double y, string operation)
    {

        double result = double.NaN;

        switch (operation)
        {
            case "a":
                result = Add();
                break;

            case "s":
                result = Substract();
                break;

            case "m":
                result = Multiply();
                break;

            case "d":
                result = Division();
                break; 

            default:
                Console.WriteLine("invalid input");
                break;
        }

        return result; 

        double Add()
        {
            Console.Clear();

            double sum = x + y;
            Console.WriteLine($"{x} + {y} = {sum}");
            return sum; 
        }

        double Substract()
        {
            Console.Clear();

            double sub = x - y;
            Console.WriteLine($"{x} - {y} = {sub}");
            return sub; 
        }

        double Multiply()
        {
            Console.Clear();

            double mult = x * y;
            Console.WriteLine($"{x} * {y} = {mult}");
            return mult; 
        }

        double Division()
        {
            Console.Clear();

            while (y == 0)
            {
                Console.WriteLine("you can't divide by zero, try again!");
                y = Convert.ToDouble(Console.ReadLine());
            }

            double div = x / y;
            Console.WriteLine($"{x} / {y} = {div}");
            return div;
            }        

    }
}
