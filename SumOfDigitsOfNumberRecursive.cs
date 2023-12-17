using System;

class program
{
    static void Main()
    {
        int num = 0, result;
        Console.WriteLine("Enter a positive number:\n");
        num = int.Parse(Console.ReadLine());
        calc c = new calc();
        result = c.sum(num);
        Console.WriteLine("Result: {0}", result);
    }
}

class calc
{
    public int sum(int num)
    {
        int s = 0, n, res;
        if (num != 0)
        {
            s = sum(num / 10);
            n = num % 10;
            res = s + n;
            return (res);
        }
        else return 0;   
    }
