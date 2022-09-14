using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(3,3,3,9)]
        [InlineData(4,5,6,15)]
        [InlineData(-1,5,3,7)]
        [InlineData(-1,-2,-3,-6)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,2,-1)]
        [InlineData(3,3,0)]
        [InlineData(15,20,-5)]
        [InlineData(9,3,6)]
        [InlineData(1000,999,1)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50,1,50)]
        [InlineData(3,0,0)]
        [InlineData(16,2,32)]
        [InlineData(-5,5,-25)]
        [InlineData(6,6,36)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50,5,10)]
        [InlineData(3,3,1)]
        [InlineData(100,10,10)]
        [InlineData(-5,5,-1)]
        [InlineData(144,12,12)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SnowMan()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            string actual = test.SnowMan();
            //Assert
            Assert.Equal("Do you want to build a snow man?", actual);
        }

        [Fact]
        // [InlineData(null, "Hello!")] // Assumption: string will not be null
        public void BoardGamesFun()
        {
            // Arrange
            var test = new UnitTestMethods();

            // Act
            string actual = test.BoardGameFun();

            // Assert
            Assert.Equal("Yes", actual);
        }
    }
}
