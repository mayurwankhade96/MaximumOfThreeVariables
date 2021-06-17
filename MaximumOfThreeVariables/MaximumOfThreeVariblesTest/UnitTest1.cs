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
            int maxNumber = Max.Max<int>(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenSecondNumberMax_WhenAct_ReturnSecondNumber()
        {
            // Arrange
            int firstNumber = 540;
            int secondNumber = 692;
            int thirdNumber = 436;
            int expected = 692;

            // Act
            int maxNumber = Max.Max<int>(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenThirdNumberMax_WhenAct_ReturnThirdNumber()
        {
            // Arrange
            int firstNumber = 540;
            int secondNumber = 692;
            int thirdNumber = 911;
            int expected = 911;

            // Act
            int maxNumber = Max.Max<int>(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenFirstFloatNumberMax_WhenAct_ReturnFirstNumber()
        {
            // Arrange
            float firstNumber = 35.1f;
            float secondNumber = 22.4f;
            float thirdNumber = 31.9f;
            float expected = 35.1f;

            // Act
            float maxNumber = Max.Max<float>(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenSecondFloatNumberMax_WhenAct_ReturnSecondNumber()
        {
            // Arrange
            float firstNumber = 22.4f;
            float secondNumber = 35.1f;
            float thirdNumber = 31.9f;
            float expected = 35.1f;

            // Act
            float maxNumber = Max.Max<float>(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenThirdFloatNumberMax_WhenAct_ReturnThirdNumber()
        {
            // Arrange
            float firstNumber = 31.9f;
            float secondNumber = 22.4f;
            float thirdNumber = 35.1f;
            float expected = 35.1f;

            // Act
            float maxNumber = Max.Max<float>(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenFirstStringWordMax_WhenAct_ReturnFirstWord()
        {
            // Arrange
            string firstWord = "Peach";
            string secondWord = "Apple";
            string thirdWord = "Banana";
            string expected = "Peach";

            // Act
            string maxString = Max.Max<string>(firstWord, secondWord, thirdWord);

            // Assert
            Assert.AreEqual(expected, maxString);
        }

        [Test]
        public void GivenSecondStringWordMax_WhenAct_ReturnSecondWord()
        {
            // Arrange
            string firstWord = "Apple";
            string secondWord = "Peach";
            string thirdWord = "Banana";
            string expected = "Peach";

            // Act
            string maxString = Max.Max<string>(firstWord, secondWord, thirdWord);

            // Assert
            Assert.AreEqual(expected, maxString);
        }

        [Test]
        public void GivenThirdStringWordMax_WhenAct_ReturnThirdWord()
        {
            // Arrange
            string firstWord = "Banana";
            string secondWord = "Apple";
            string thirdWord = "Peach";
            string expected = "Peach";

            // Act
            string maxString = Max.Max<string>(firstWord, secondWord, thirdWord);

            // Assert
            Assert.AreEqual(expected, maxString);
        }
    }
}