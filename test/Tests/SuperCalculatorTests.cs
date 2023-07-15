using App.Services;
using FluentAssertions;

namespace Tests;

public class SuperCalculatorTests
{
    [Theory]
    [InlineData(20, 10, 10)]
    [InlineData(30, 30, 30)]
    [InlineData(40, 50, 40)]
    public void Should_Min_Be_Valid(decimal number1, decimal number2, decimal expectedMin)
    {
        // arrange
        var calculator = new SuperCalculator();

        // act
        var min = calculator.Min(number1, number2);

        // assert
        min.Should().Be(expectedMin);
    }
    
    [Theory]
    [InlineData(20, 10, 20)]
    [InlineData(30, 30, 30)]
    [InlineData(40, 50, 50)]
    public void Should_Max_Be_Valid(decimal number1, decimal number2, decimal expectedMax)
    {
        // arrange
        var calculator = new SuperCalculator();

        // act
        var max = calculator.Max(number1, number2);

        // assert
        max.Should().Be(expectedMax);
    }
    
    [Theory]
    [InlineData(20, 30, 50)]
    [InlineData(30, 40, 70)]
    [InlineData(40, 50, 90)]
    public void Should_Sum_Be_Valid(decimal number1, decimal number2, decimal expectedSum)
    {
        // arrange
        var calculator = new SuperCalculator();

        // act
        var sum = calculator.Sum(number1, number2);

        // assert
        sum.Should().Be(expectedSum);
    }
}