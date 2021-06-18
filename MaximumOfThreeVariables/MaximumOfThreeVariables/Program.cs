using System;

namespace MaximumOfThreeVariables
{
    class Program
    {
        static void Main()
        {
            // Creating object
            MaxNumber max = new MaxNumber();

            int[] intArray = { 1, 45, 69, 33, 26 };
            max.MaxValue<int>(intArray);

            double[] doubleArray = { 45.26, 36.24, 15.46, 36.23 };
            max.MaxValue<double>(doubleArray);

            string[] stringArray = { "45", "89", "75", "84" };
            max.MaxValue<string>(stringArray);
        }
    }
}
