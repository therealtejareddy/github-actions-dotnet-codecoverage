namespace GACodeCoveragePoc.Tests.GACodeCoveragePoc
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_TwoNumbersPass()
        {
            // Arrange
            int a = 5;
            int b = 5;
            int expected = 10;

            // Act
            int output = Calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Add_ThreeNumbersPass()
        {
            // Arrange
            int a = 5;
            int b = 5;
            int expected = 15;

            // Act
            int output = Calculator.Add(a, b,a);

            // Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Add_FourNumbersPass()
        {
            // Arrange
            int a = 5;
            int b = 5;
            int expected = 10;

            // Act
            int output = Calculator.Add(a, b, a, b);

            // Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Subtract_Pass()
        {
            // Arrange
            int a = 5;
            int b = 5;
            int expected = 0;

            // Act
            int output = Calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Multiply_TwoNumbersPass()
        {
            // Arrange
            int a = 5;
            int b = 5;
            int expected = 25;

            // Act
            int output = Calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, output);
        }
    }
}