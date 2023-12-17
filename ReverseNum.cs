using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, result = 0, rest;
            string revNum = "";
            Console.WriteLine("Enter a num: ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rest = num % 10;
                num = num / 10;
                revNum = string.Concat(revNum, rest.ToString());
                result = int.Parse(revNum);
            }
            Console.WriteLine("Reversed Num: {0}", result);
        }
    }
}