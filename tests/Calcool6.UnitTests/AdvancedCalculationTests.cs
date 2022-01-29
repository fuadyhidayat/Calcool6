using Calcool6.Application;
using FluentAssertions;
using Xunit;

namespace Calcool6.UnitTests;

public class AdvancedCalculationTests
{
    [Theory]
    [InlineData(0, 0, 0)]
    public void ShouldGetPowerResult(int input1, int input2, double expectedResult)
    {
        var result = AdvancedCalculation.Power(input1, input2);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    public void ShouldGetRemainderResult(int input1, int input2, int expectedResult)
    {
        var result = AdvancedCalculation.Remainder(input1, input2);

        result.Should().Be(expectedResult);
    }
}
