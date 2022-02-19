using Calcool6.Application;
using FluentAssertions;
using System;
using Xunit;

namespace Calcool6.UnitTests;

public class AdvancedCalculationTests
{
    [Theory]
    [InlineData(2, 3, 8)]
    [InlineData(-5, 4, 625)]
    [InlineData(6, 0, 1)]
    public void ShouldGetPowerResult(int input1, int input2, double expectedResult)
    {
        var result = AdvancedCalculation.Power(input1, input2);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(7, 2, 1)]
    [InlineData(10, 5, 0)]
    [InlineData(8, -3, 2)]
    [InlineData(-25, 7, -4)]
    [InlineData(-10, -8, -2)]
    public void ShouldGetRemainderResult(int input1, int input2, int expectedResult)
    {
        var result = AdvancedCalculation.Remainder(input1, input2);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void ShouldThrowDivideByZeroException()
    {
        Action remainder = () => AdvancedCalculation.Remainder(1, 0);

        remainder.Should().Throw<DivideByZeroException>();
    }
}
