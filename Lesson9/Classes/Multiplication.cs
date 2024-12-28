using Lesson9.Interfaces.ICalculatorOperation;

namespace Lesson9.Classes.Multiplication;

public class Multiplication : ICalculatorOperation{
    public string Name => "Multiplication";
    public double Execute(double a, double b){
        return a * b;
    }
}