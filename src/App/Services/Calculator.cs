namespace App.Services;

public interface ICalculator
{
    decimal Min(params decimal[] numbers);
    decimal Max(params decimal[] numbers);
}

public class Calculator : ICalculator
{
    public decimal Min(params decimal[] numbers)
    {
        return numbers.Min();
    }

    public decimal Max(params decimal[] numbers)
    {
        return numbers.Max();
    }
}