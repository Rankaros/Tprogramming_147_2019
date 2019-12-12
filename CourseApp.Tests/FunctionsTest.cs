using System;
using Xunit;

namespace CourseApp.Tests
{
    public class FunctionsTest
    {
        [Theory]
        [InlineData(0, 0, 0, double.NaN)]
        [InlineData(2, 2, 2, 2.5)]
        [InlineData(-2, -2, 2, 2.5)]

        public void TestCalc(double a, double b, double x, double exp)
        {
            var res = Program.MyFunction(a, b, x);
            Assert.Equal(exp, res, 3);
        }

        [Fact]
        public void TestNormalA()
        { // var NormalA = Functions.TaskA(0.15, 1.37, 0.25);var score = new double[]
        }

        [Fact]
        public void TestNormalB()
        {
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Program.TaskB(2, 3, new double[0]);
            Assert.Empty(res);
        }
    }
}