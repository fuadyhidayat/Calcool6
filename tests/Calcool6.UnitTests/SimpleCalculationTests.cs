using Calcool6.Application;
using FluentAssertions;
using Xunit;

namespace Calcool6.UnitTests;

public class SimpleCalculationTests
{
    [Theory]
    [InlineData(5, 8, 14)]
    [InlineData(16, -7, 9)]
    [InlineData(-8, 10, 2)]
    [InlineData(-2, -27, -29)]
    public void ShouldGetAdditionResult(int input1, int input2, int expectedResult)
    {
        var result = SimpleCalculation.Add(input1, input2);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(19, 9, 10)]
    [InlineData(8, -8, 16)]
    [InlineData(-11, 15, -26)]
    [InlineData(-4, -16, 12)]
    [InlineData(-7, -2, -5)]
    public void ShouldGetSubtractionResult(int input1, int input2, int expectedResult)
    {
        var result = SimpleCalculation.Subtract(input1, input2);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(3, 6, 18)]
    [InlineData(2, -7, -14)]
    [InlineData(-4, 21, -84)]
    [InlineData(-9, -6, 54)]
    public void ShouldGetMultiplicationResult(int input1, int input2, int expectedResult)
    {
        var result = SimpleCalculation.Multiply(input1, input2);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(7, 2, 3.5)]
    [InlineData(9, -3, -3)]
    [InlineData(-25, 5, -5)]
    [InlineData(-10, -8, 1.25)]
    [InlineData(1, 0, double.PositiveInfinity)]
    public void ShouldGetDivisionResult(int input1, int input2, double expectedResult)
    {
        var result = SimpleCalculation.Divide(input1, input2);

        result.Should().Be(expectedResult);
    }
}
