using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumOfThreeVariables
{
    public class MaxNumber
    {
        dynamic temp;
        public void MaxValue<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++) // For number of passes
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Maximum is : " + array[array.Length - 1]);
        }
    }
}
