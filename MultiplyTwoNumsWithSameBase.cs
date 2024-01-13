// Multiply two numbers with the same base.
// 2^1*2^2 = 2^2

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter base: ");
        double base1 = double.Parse(Console.ReadLine());
        Console.Write("Enter first exponent: ");
        double exp1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second Exponent: ");
        double exp2 = double.Parse(Console.ReadLine());
        double exp = exp1 + exp2;
        double result = Math.Pow(base1, exp);
        Console.WriteLine("Result: {0}^{1} = {2}", base1, exp, result);
    }
}