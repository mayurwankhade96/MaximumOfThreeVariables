using System;

namespace MaximumOfThreeVariables
{
    class Program
    {
        static void Main()
        {
            MaxNumber max = new MaxNumber();
            int maxNumber = max.MaxInteger(10, 8, 9);
            Console.WriteLine(maxNumber + " is maximum");
        }
    }
}
