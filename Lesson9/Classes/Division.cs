using Lesson9.Interfaces.ICalculatorOperation;

namespace Lesson9.Classes.Division;

public class Division : ICalculatorOperation{
    public string Name => "Division";
    public double Execute(double a, double b){
        if (b == 0)
            throw new DivideByZeroException("The division to zero is impossible!");
        return a / b;
    }
}