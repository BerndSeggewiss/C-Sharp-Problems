using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArithmethics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Menu\n");
            Console.Write("Addition - A\n");
            Console.Write("Multiplication - M\n");
            Console.Write("Subtraction - S\n");
            Console.Write("Division - D\n");
            char choice;
            choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 'A':
                    result = num1 + num2;
                    Console.WriteLine("The result is: " + result);
                    break;

                case 'M':
                    result = num1 * num2;
                    Console.WriteLine("The result is: " + result);
                    break;

                case 'S':
                    result = num1 - num2;
                    Console.WriteLine("The result is: " + result);
                    break;

                case 'D':
                    result = num1 / num2;
                    Console.WriteLine("The result is: " + result);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}