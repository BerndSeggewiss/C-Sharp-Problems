/*Multiplicaation of two binary nums. E.g.:
Put in num 1: 1111
Put in num 2: 1010
The prduct is 10010110*/

using System;

namespace MultiplyBinaryNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicand, multiplier;
            string strMultiplicand, strMultiplier;
            Console.Write("Put in num 1: ");
            strMultiplicand = Console.ReadLine();
            multiplicand = Convert.ToInt32(strMultiplicand, 2);
            Console.Write("Put in num 2: ");
            strMultiplier = Console.ReadLine();
            multiplier = Convert.ToInt32(strMultiplier, 2);
            int result = 0;
            while (multiplier != 0)
            {
                Console.WriteLine("multiplier " + Convert.ToString(multiplier, 2));
                if ((multiplier & 1) != 0)
                {
                    result += multiplicand;
                    
                }
                multiplicand <<= 1;
                multiplier >>= 1;
            }
            Console.WriteLine("The product is: " + Convert.ToString(result, 2));
        }
    }
}