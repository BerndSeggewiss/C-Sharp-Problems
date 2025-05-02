public class calculate
{
    public calculate() { }
    public string result = "";

    public string convert2Binary(int num)
    {
        int rem;
        if (num == 0)
            return "0";
        if (num != 0)
        {
            rem = num % 2;
            num = num / 2;
            result = rem.ToString() + result;
            convert2Binary(num);
        }
        return result;
    }

    public string FormatBinary(string binary)
    {
        int padding = 4 - (binary.Length % 4);
        if (padding != 4)
        {
            binary = new string('0', padding) + binary;
        }
        string formattedBinary = "";
        for (int i = 0; i < binary.Length; i++)
        {
            formattedBinary += binary[i];
            if ((i + 1) % 4 == 0 && i != binary.Length - 1)
            {
                formattedBinary += " ";
            }
        }
        return formattedBinary;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter an integer number: \n");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out num))
        {
            Console.WriteLine("Invalid input. Enter a valid integer number...");
            return;
        }
        calculate calc = new calculate();
        string binary = calc.convert2Binary(num);
        string formattedBinary = calc.FormatBinary(binary);
        Console.WriteLine($"Binary representation: {formattedBinary}");
    }
}

