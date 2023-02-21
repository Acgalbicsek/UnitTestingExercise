using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(8, 6, 2, 16)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(16, 4, 12)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test1 = new Calculator();

            //Act
            var actual = test1.SubtractTest(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual); 

        }

        [Theory]
        [InlineData(4, 4, 16)]
        [InlineData(12, 4, 48)]
        [InlineData(5, 4, 20)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test2 = new Calculator();

            //Act
            var actual = test2.MultiplyTest(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(40, 4, 10)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new Calculator();

            //Act
            var actual = test3.DivideTest(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
