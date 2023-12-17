/*
 * Adding to binary nums.
 * Put in Num1: 111
 * Put in Num2: 1010
 * Result: 10001
 */

using System;

namespace AddingTwoBinaryNums
{
    internal class Program
    {
        public static object BigInteger { get; private set; }

        static void Main(string[] args)
        {
            Console.Write("Put in Num1: ");
            string strNum1 = Console.ReadLine();
            Console.Write("Put in Num2: ");
            string strNum2 = Console.ReadLine();
            if (strNum1.Length < strNum2.Length)
            {
                strNum1 = strNum1.PadLeft(strNum2.Length, '0');
            }
            else if (strNum2.Length < strNum1.Length) 
            {
                strNum2 = strNum2.PadLeft(strNum1.Length, '0');
            }
            string result = "";
            int carry = 0;
            for (int i = strNum1.Length - 1; i >= 0; i--) 
            {
                int sum = (strNum1[i] - '0') + (strNum2[i] - '0') + carry;
                result = (sum % 2).ToString() + result;
                carry = sum / 2;
            }
            if (carry == 1)
            {
                result = '1' + result;
            }
            Console.WriteLine("Result: {0} ", result);
        }
    }
}

