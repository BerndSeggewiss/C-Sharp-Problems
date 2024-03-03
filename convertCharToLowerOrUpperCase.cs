using System;

class program
{
    static void Main(string[] args)
    {
        char ch;
        int decChar;
        Console.WriteLine("Put in a character:");
        ch = Convert.ToChar(Console.ReadLine());
        decChar = (int)ch;
        Console.WriteLine($"The decimal value from '{ch}' is {decChar}.");
        if (ch >= 65 && ch <= 90)
        {
            ch = char.ToLower(ch);
            Console.WriteLine($"The lower case is: '{ch}'");
        }
        else if (ch >= 97 && ch <= 122)
        {
            ch = char.ToUpper(ch);
            Console.WriteLine($"The upper case is: '{ch}'");
        }
    }
}