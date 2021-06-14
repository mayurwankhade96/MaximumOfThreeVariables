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

            int maxNumberTwo = max.MaxInteger(540, 692, 436);
            Console.WriteLine(maxNumberTwo + " is maximum");

            int maxNumberThree = max.MaxInteger(540, 692, 911);
            Console.WriteLine(maxNumberThree + " is maximum");
        }
    }
}
