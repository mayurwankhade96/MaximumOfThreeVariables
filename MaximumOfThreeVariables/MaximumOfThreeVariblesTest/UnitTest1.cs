using MaximumOfThreeVariables;
using NUnit.Framework;

namespace MaximumOfThreeVariblesTest
{
    public class Tests
    {
        [Test]
        public void GivenFirstNumberMax_WhenAct_ReturnFirstNumber()
        {
            MaxNumber<int> max = new MaxNumber<int>(10, 8, 9);

            // Arrange            
            int expected = 10;

            // Act
            int maxNumber = max.Max();

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenSecondNumberMax_WhenAct_ReturnSecondNumber()
        {
            MaxNumber<int> max = new MaxNumber<int>(8, 10, 9);

            // Arrange            
            int expected = 10;

            // Act
            int maxNumber = max.Max();

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }


        [Test]
        public void GivenThirdNumberMax_WhenAct_ReturnThirdNumber()
        {
            MaxNumber<int> max = new MaxNumber<int>(9, 8, 10);

            // Arrange
            int expected = 10;

            // Act
            int maxNumber = max.Max();

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenFirstFloatNumberMax_WhenAct_ReturnFirstNumber()
        {
            MaxNumber<float> max = new MaxNumber<float>(10.45f, 8.25f, 9.26f);

            // Arrange            
            float expected = 10.45f;

            // Act
            float maxNumber = max.Max();

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenSecondFloatNumberMax_WhenAct_ReturnSecondNumber()
        {
            MaxNumber<float> max = new MaxNumber<float>(8.25f, 10.45f, 9.26f);

            // Arrange
            float expected = 10.45f;

            // Act
            float maxNumber = max.Max();

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenThirdFloatNumberMax_WhenAct_ReturnThirdNumber()
        {
            MaxNumber<float> max = new MaxNumber<float>(8.25f, 9.26f, 10.45f);

            // Arrange
            float expected = 10.45f;

            // Act
            float maxNumber = max.Max();

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenFirstStringWordMax_WhenAct_ReturnFirstWord()
        {
            MaxNumber<string> max = new MaxNumber<string>("Peach", "Apple", "Banana");

            // Arrange            
            string expected = "Peach";

            // Act
            string maxString = max.Max();

            // Assert
            Assert.AreEqual(expected, maxString);
        }

        [Test]
        public void GivenSecondStringWordMax_WhenAct_ReturnSecondWord()
        {
            MaxNumber<string> max = new MaxNumber<string>("Apple", "Peach", "Banana");

            // Arrange            
            string expected = "Peach";

            // Act
            string maxString = max.Max();

            // Assert
            Assert.AreEqual(expected, maxString);
        }

        [Test]
        public void GivenThirdStringWordMax_WhenAct_ReturnThirdWord()
        {
            MaxNumber<string> max = new MaxNumber<string>("Banana", "Apple", "Peach");

            // Arrange            
            string expected = "Peach";

            // Act
            string maxString = max.Max();

            // Assert
            Assert.AreEqual(expected, maxString);
        }
    }
}