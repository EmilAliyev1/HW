using Lesson9.Classes.Addition;
using Lesson9.Classes.Division;
using Lesson9.Classes.Multiplication;
using Lesson9.Classes.Subtraction;
using Lesson9.Interfaces.ICalculatorOperation;

namespace Lesson9.CUI.CalculatorUi;

public class CalculatorUi
{
    private List<ICalculatorOperation> _operations = new()
    {
        new Addition(),
        new Subtraction(),
        new Multiplication(),
        new Division(),
    };

    private void WriteOperationsNames()
    {
        for (int i = 0; i < _operations.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {_operations[i].Name}");
        }
        Console.WriteLine($"{_operations.Count + 1} - Exit");
    }

    private int GetChoice()
    {
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            throw new Exception("Invalid input");
        }
        if (choice < 1 || choice > _operations.Count + 1)
        {
            throw new Exception("The entered choice is out of range");
        }

        return choice;
    }

    private double GetNumber()
    {
        if (!double.TryParse(Console.ReadLine(), out double num))
        {
            throw new Exception("Invalid input. You must enter a number!");
        }

        return num;
    }

    public CalculatorUi()
    {
        while (true)
        {
            try
            {
                WriteOperationsNames();

                Console.Write("Enter your choice: ");
                int choice = GetChoice();

                if (choice == _operations.Count + 1)
                {
                    Console.WriteLine("Good bye!");
                    break;
                }

                double a = GetNumber();
                double b = GetNumber();

                var operation = _operations[choice - 1];
                double res = operation.Execute(a, b);

                Console.WriteLine($"The result is: {res}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
