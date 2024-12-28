namespace Lesson9.Interfaces.ICalculatorOperation;

public interface ICalculatorOperation{
    string Name { get; }
    double Execute(double a, double b);
}