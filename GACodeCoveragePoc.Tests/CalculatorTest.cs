namespace GACodeCoveragePoc.Tests
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
    }
}