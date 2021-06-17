using System;

namespace MaximumOfThreeVariables
{
    class Program
    {
        static void Main()
        {
            // Creating object
            MaxNumber max = new MaxNumber();

            Console.WriteLine(max.Max<int>(45, 56, 41));
            Console.WriteLine(max.Max<float>(45.12f, 36.45f, 12.11f));
            Console.WriteLine(max.Max<string>("Apple", "Peach", "Banana"));
        }
    }
}
