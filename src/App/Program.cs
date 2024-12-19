using System.Security.Cryptography;
using App.Services;

var numbers = Enumerable.Range(0, 100)
    .Select(x => new decimal(RandomNumberGenerator.GetInt32(1000)))
    .ToArray();

var calculator = new Calculator();
var min = calculator.Min(numbers);
var max = calculator.Max(numbers);

var superCalculator = new SuperCalculator();
var sum = superCalculator.Sum(numbers);

Console.WriteLine($"Min = {min}");
Console.WriteLine($"Max = {max}");
Console.WriteLine($"Sum = {sum}");