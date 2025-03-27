using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        
        
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(5, 5, 5, 15)]
        [InlineData(2, 2, 3, 7)]
        [InlineData(0, 0, 0, 0)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
        var test = new Calculator();


            // create a Calculator object


            //Act
            var actual = test.Add(num1, num2, num3);
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(5,10,-5)]
        [InlineData(50, 25, 25)]
        [InlineData(30, 6, 24)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test1 = new Calculator();

            //Act
            var actual = test1.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,5,25)]
        [InlineData(2, 8, 16)]
        [InlineData(40,3,120)]
        [InlineData(0, 50, 0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test2 = new Calculator();

            //Act
            var actual = test2.Multiply( num1, num2 );

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(14,2,7)]
        [InlineData(50, 2, 25)]
        [InlineData(36, 6, 6)]
        [InlineData(10, 2, 5)]//Add test data <-------
        public void DivideTest(int number1, int number2, int expected)
        {
            //Arrange
            var test3 = new Calculator();

            //Act
            var actual = test3.Divide(number1, number2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
