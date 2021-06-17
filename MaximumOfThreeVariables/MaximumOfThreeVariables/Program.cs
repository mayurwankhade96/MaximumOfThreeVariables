using System;

namespace MaximumOfThreeVariables
{
    class Program
    {
        static void Main()
        {
            // Creating object
            MaxNumber<int> max = new MaxNumber<int>(45,56,54);
            MaxNumber<float> maxfloat = new MaxNumber<float>(45.45f, 56.12f, 54.457f);
            MaxNumber<string> maxstring = new MaxNumber<string>("Apple", "Peach", "Banana");


            Console.WriteLine(max.Max());
            Console.WriteLine(maxfloat.Max());
            Console.WriteLine(maxstring.Max());
        }
    }
}
