using MaximumOfThreeVariables;
using NUnit.Framework;

namespace MaximumOfThreeVariblesTest
{
    public class Tests
    {
        MaxNumber Max = new MaxNumber();

        [Test]
        public void GivenFirstNumberMax_WhenAct_ReturnFirstNumber()
        {
            // Arrange
            int firstNumber = 10;
            int secondNumber = 8;
            int thirdNumber = 9;
            int expected = 10;

            // Act
            int maxNumber = Max.MaxInteger(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }
    }
}