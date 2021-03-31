using System;

namespace UC2_FindMaxmimum
{
    class Program
    {
        static void Main(string[] args)
        {
            sole.WriteLine("Welcome to Find Maximum Problem using Generics");

            int integerOutput = MaximumNumberCheck.MaximumIntegerNumber(11, 44, 33);
            Console.WriteLine(integerOutput);

            double doubleOutput = MaximumNumberCheck.MaximumFloatNumber(111.44, 44.20, 33.65);
            Console.WriteLine(doubleOutput);
        }
    }
}
