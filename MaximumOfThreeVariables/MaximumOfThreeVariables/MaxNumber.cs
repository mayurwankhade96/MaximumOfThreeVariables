using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumOfThreeVariables
{
    public class MaxNumber
    {
        /// <summary>
        /// Generic method to find max value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public T Max<T>(T firstNumber, T secondNumber, T thirdNumber) where T : IComparable
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0 ||
                firstNumber.CompareTo(secondNumber) >= 0 && firstNumber.CompareTo(thirdNumber) > 0 ||
                firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) >= 0)
                return firstNumber;

            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0 ||
                secondNumber.CompareTo(firstNumber) >= 0 && secondNumber.CompareTo(thirdNumber) > 0 ||
                secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) >= 0)
                return secondNumber;

            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0 ||
                thirdNumber.CompareTo(firstNumber) >= 0 && thirdNumber.CompareTo(secondNumber) > 0 ||
                thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) >= 0)
                return thirdNumber;

            throw new Exception("All values are same");
        }
    }
}
