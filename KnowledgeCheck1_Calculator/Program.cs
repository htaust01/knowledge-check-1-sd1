using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator 2!");
            Console.WriteLine();
            string input;
            do
            {
                Console.Write("Enter '1' for addition, '2' for subtraction, '3' for multiplication, '4' for division, and 'Q' to quit: ");
                input = Console.ReadLine().ToUpper();
                var calculator = new Calculator();
                switch (input)
                {
                    case "1":
                        var addNumber1 = GetInteger("first", "addition");
                        var addNumber2 = GetInteger("second", "addition");
                        Console.Write($"{addNumber1} + {addNumber2} = ");
                        Console.WriteLine(calculator.Add(addNumber1, addNumber2));
                        break;
                    case "2":
                        var subtractNumber1 = GetInteger("first", "subtraction");
                        var subtractNumber2 = GetInteger("second", "subtraction");
                        Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                        Console.WriteLine(calculator.Subtract(subtractNumber1, subtractNumber2));
                        break;
                    case "3":
                        var multiplyNumber1 = GetInteger("first", "multiplication");
                        var multiplyNumber2 = GetInteger("second", "multiplication");
                        Console.Write($"{multiplyNumber1} x {multiplyNumber2} = ");
                        Console.WriteLine(calculator.Multiply(multiplyNumber1, multiplyNumber2));
                        break;
                    case "4":
                        var divideNumber1 = (double)GetInteger("first", "division");
                        var divideNumber2 = (double)GetInteger("second", "division");
                        Console.Write($"{divideNumber1} / {divideNumber2} = ");
                        Console.WriteLine(calculator.Divide(divideNumber1, divideNumber2));
                        break;
                    case "Q":
                        Console.WriteLine("Calc-You-Later :P");
                        break;
                    default:
                        Console.WriteLine("Unknown input");
                        break;
                }
            } while (input != "Q");       
        }

        static int GetInteger(string orderOfNumbers, string operation)
        {
            Console.Write($"Enter the {orderOfNumbers} integer for {operation}: ");
            int number;
            while (!Int32.TryParse(Console.ReadLine(), out number))
                Console.Write("Please enter an integer: ");
            return number;
        }
    }
}