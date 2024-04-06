/* Find the range of data types */

using System;

namespace dataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimum Range of decimal data  is : {0} ", Decimal.MinValue);
            Console.WriteLine("Maximum Range of decimal data  is : {0} ", Decimal.MaxValue);
            Console.WriteLine("Minimum Range of float data  is : {0} ", Single.MinValue);
            Console.WriteLine("Maximum Range of float data  is : {0} ", Single.MaxValue);
            Console.WriteLine("Minimum Range of double data  is : {0} ", Double.MinValue);
            Console.WriteLine("Maximum Range of double data  is : {0} ", Double.MaxValue);
            Console.WriteLine("Minimum Range of long data  is : {0} ", Int64.MinValue);
            Console.WriteLine("Maximum Range of long data  is : {0} ", Int64.MaxValue);
        }
    }
}
