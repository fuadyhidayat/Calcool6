using Calcool6.Application;
using FluentAssertions;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Calcool6.UnitTests;

[ExcludeFromCodeCoverage]
public class SimpleCalculationTests
{
    [Theory]
    [InlineData(0, 0, 0)]
    public void ShouldGetAdditionResult(int input1, int input2, int expectedResult)
    {
        // Act
        var result = SimpleCalculation.Add(input1, input2);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    public void ShouldGetSubtractionResult(int input1, int input2, int expectedResult)
    {
        // Act
        var result = SimpleCalculation.Subtract(input1, input2);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    public void ShouldGetMultiplicationResult(int input1, int input2, int expectedResult)
    {
        // Act
        var result = SimpleCalculation.Multiply(input1, input2);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    public void ShouldGetDivisionResult(int input1, int input2, double expectedResult)
    {
        // Act
        var result = SimpleCalculation.Divide(input1, input2);

        // Assert
        result.Should().Be(expectedResult);
    }
}
