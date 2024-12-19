namespace App.Services;

public interface ISuperCalculator : ICalculator
{
    decimal Sum(params decimal[] numbers);
}

public class SuperCalculator : Calculator, ISuperCalculator
{
    public decimal Sum(params decimal[] numbers)
    {
        return numbers.Sum();
    }
}