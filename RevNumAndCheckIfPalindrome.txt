// Program reverse a number and check if is palindrome

using System;

namespace RevNumAndCheckIfPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, tempNum, result = 0, rest;
            string revNum = "";
            bool Flag = false;
            Console.WriteLine("Enter a num: ");
            num = int.Parse(Console.ReadLine());
            tempNum = num;
            while (num != 0)
            {
                rest = num % 10;
                num = num / 10;
                revNum = string.Concat(revNum, rest.ToString());
                result = int.Parse(revNum);
            }
            if (tempNum == result)
                Flag = true;
            Console.WriteLine(Flag ? "Number is palindroime" : "Number is not palindrome");
        }
    }
}