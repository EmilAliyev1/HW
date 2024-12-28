using Lesson9.Interfaces.ICalculatorOperation;

namespace Lesson9.Classes.Addition;

public class Addition : ICalculatorOperation{
    public string Name => "Addition";
    public double Execute(double a, double b){
        return a + b;
    }
}