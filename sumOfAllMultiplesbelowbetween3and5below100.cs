using System;
class program
{
    public static void Main()
    {
        int a, b, i, sum = 0;
        for (i = 1; i < 100; i++)
        {
            a = i % 3;
            b = i % 5;
            if (a == 0 || b == 0)
            {
                Console.Write("{0}\t", i);
                sum = sum + i;
            }
        }
        Console.WriteLine("\nSum of all multiples between 3 and 5 below 100", sum);
    }
}