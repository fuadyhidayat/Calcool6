using Calcool6.Application;
using FluentAssertions;
using Xunit;

namespace Calcool6.UnitTests;

public class SimpleCalculationTests
{
    [Theory]
    [InlineData(0, 0, 0)]
    public void ShouldGetAdditionResult(int input1, int input2, int expectedResult)
    {
        var result = SimpleCalculation.Add(input1, input2);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    public void ShouldGetSubtractionResult(int input1, int input2, int expectedResult)
    {
        var result = SimpleCalculation.Subtract(input1, input2);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    public void ShouldGetMultiplicationResult(int input1, int input2, int expectedResult)
    {
        var result = SimpleCalculation.Multiply(input1, input2);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    public void ShouldGetDivisionResult(int input1, int input2, double expectedResult)
    {
        var result = SimpleCalculation.Divide(input1, input2);

        result.Should().Be(expectedResult);
    }
}
