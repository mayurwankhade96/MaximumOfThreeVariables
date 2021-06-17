using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumOfThreeVariables
{
    public class MaxNumber<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fValue"></param>
        /// <param name="sValue"></param>
        /// <param name="tValue"></param>
        public MaxNumber(T fValue, T sValue, T tValue)
        {
            firstValue = fValue;
            secondValue = sValue;
            thirdValue = tValue;
        }

        /// <summary>
        /// Method to find maximum
        /// </summary>
        /// <returns></returns>
        public T Max()
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
                return firstValue;

            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
                return secondValue;

            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
                return thirdValue;

            return default;
        }
    }
}
