using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 6, 7, 16)]
        [InlineData(5, 5, 5, 15)]
        [InlineData(4, 5, 4, 13)]
        [InlineData(3, 0, 5, 8)]
        [InlineData(9, 15, 33, 57)]
        [InlineData(100, 550, 100, 750)]
        [InlineData(-2, -3, 5, 0)]
        [InlineData(-10, 5, 10, 5)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            Calculator calculator = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                int actual = calculator.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(5, 5, 0)]
        [InlineData(10, 4, 6)]
        [InlineData(100, 25, 75)]
        [InlineData(1000, 500, 500)]
        [InlineData(-5, -20, 15)]
        [InlineData(-50, -50, 0)]
        [InlineData(-30, 7, -37)]
        [InlineData(-4, 24, -28)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(5, 5, 25)]
        [InlineData(11, 3, 33)]
        [InlineData(0, 0, 0)]
        [InlineData(-3, 10, -30)]
        [InlineData(-7, -7, 49)]
        [InlineData(100, 0, 0)]
        [InlineData(-5, 0, 0)]
        [InlineData(100, 1, 100)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 1, 5)]
        [InlineData(10, 2, 5)]
        [InlineData(10, 10, 1)]
        [InlineData(100, 50, 2)]
        [InlineData(25, 5, 5)]
        [InlineData(-50, -5, 10)]
        [InlineData(-250, 5, -50)]
        [InlineData(60, -2, -30)]
        [InlineData(-1000, -1000, 1)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
