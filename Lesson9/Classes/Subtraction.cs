using Lesson9.Interfaces.ICalculatorOperation;

namespace Lesson9.Classes.Subtraction;

public class Subtraction : ICalculatorOperation
{
    public string Name => "Subtraction";

    public double Execute(double a, double b)
    {
        return a - b;
    }
}
