using App.Services;
using FluentAssertions;

namespace Tests;

public class CalculatorTests
{
    [Theory]
    [InlineData(20, 10, 10)]
    [InlineData(30, 30, 30)]
    [InlineData(40, 50, 40)]
    public void ShouldMinBeValid(decimal number1, decimal number2, decimal expectedMin)
    {
        // arrange
        var calculator = new Calculator();

        // act
        var min = calculator.Min(number1, number2);

        // assert
        min.Should().Be(expectedMin);
    }

    [Theory]
    [InlineData(20, 10, 20)]
    [InlineData(30, 30, 30)]
    [InlineData(40, 50, 50)]
    public void ShouldMaxBeValid(decimal number1, decimal number2, decimal expectedMax)
    {
        // arrange
        var calculator = new Calculator();

        // act
        var max = calculator.Max(number1, number2);

        // assert
        max.Should().Be(expectedMax);
    }
}