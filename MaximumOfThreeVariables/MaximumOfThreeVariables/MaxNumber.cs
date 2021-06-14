using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumOfThreeVariables
{
    public class MaxNumber
    {
        public int MaxInteger(int firstNumber, int secondNumber, int thirdNumber)
        {
            if ((firstNumber.CompareTo(secondNumber) > 0) && (firstNumber.CompareTo(thirdNumber) > 0))
                return firstNumber;
            if ((secondNumber.CompareTo(firstNumber) > 0) && (secondNumber.CompareTo(thirdNumber) > 0))
                return secondNumber;
            if ((thirdNumber.CompareTo(firstNumber) > 0) && (thirdNumber.CompareTo(secondNumber) > 0))
                return thirdNumber;
            return 0;
        }

        public float MaxFloat(float firstNumber, float secondNumber, float thirdNumber)
        {
            if ((firstNumber.CompareTo(secondNumber) > 0) && (firstNumber.CompareTo(thirdNumber) > 0))
                return firstNumber;
            if ((secondNumber.CompareTo(firstNumber) > 0) && (secondNumber.CompareTo(thirdNumber) > 0))
                return secondNumber;
            if ((thirdNumber.CompareTo(firstNumber) > 0) && (thirdNumber.CompareTo(secondNumber) > 0))
                return thirdNumber;
            return 0;
        }
    }
}
