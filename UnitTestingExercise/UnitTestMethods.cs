using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Create an Add method that passes 3 integers
        public int Add(int one, int two, int three)
        {
            return one + two + three;
        }
        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int one, int two)
        {
            return one - two;
        }
        // Create a Multiply method that passes 2 integers
        public int Multiply(int one, int two)
        {
            return one * two;
        }
        // Create a Divide method that passes 2 integers
        public int Divide(int one, int two)
        {
            return one / two;
        }
        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string SnowMan()
        {
            return "Do you want to build a snow man?";
        }
        public string BoardGameFun()
        {
            return "Yes";
        }
    }
}
