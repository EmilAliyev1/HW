using System.Globalization; // dla ispozovaniya klassa CultureInfo ctobi mojno bilo ispolzovat real time datu

// Exercise 1

Console.WriteLine("Exercise 1");

Console.Write("Enter number from 1 to 100: ");
int number = int.Parse(Console.ReadLine());

if (number < 1 || number > 100)
{
    Console.WriteLine("Error: the number must be between 1 and 100.");
}
else
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine("Fizz Buzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(number);
    }
}

// Exercise 2

Console.WriteLine("\nExercise 2");

Console.Write("Enter number: ");
double value = double.Parse(Console.ReadLine());

Console.Write("Enter percentage: ");
double percentage = double.Parse(Console.ReadLine());

double result = value * (percentage / 100);
Console.WriteLine($"{percentage}% from {value} = {result:F2}");

// Exercise 3

Console.WriteLine("\nExercise 3");

Console.Write("Enter first number: ");
string digit1 = Console.ReadLine();

Console.Write("Enter second number: ");
string digit2 = Console.ReadLine();

Console.Write("Enter third number: ");
string digit3 = Console.ReadLine();

Console.Write("Enter fourth number: ");
string digit4 = Console.ReadLine();

string result2 = digit1 + digit2 + digit3 + digit4;
Console.WriteLine($"The resulting number: {result2}");

// Exercise 4

Console.WriteLine("\nExercise 4");

Console.Write("Enter a six-digit number: ");
string number2 = Console.ReadLine();

if (number2.Length != 6)
{
    Console.WriteLine("Error: The number must be six digits.");
    return;
}

Console.Write("Enter the index of the first digit: ");
int pos1 = int.Parse(Console.ReadLine()) - 1;

Console.Write("Enter the index of the second digit: ");
int pos2 = int.Parse(Console.ReadLine()) - 1;

char[] digits = number2.ToCharArray();
char temp = digits[pos1];
digits[pos1] = digits[pos2];
digits[pos2] = temp;

string result3 = new string(digits);
Console.WriteLine($"Result: {result3}");

// Exercise 5 (chatgpt pomog nayti sposob ctobi ya mog obrasatsa realnomu vremeni)

Console.WriteLine("\nExercise 5");

Console.Write("Enter date (dd.mm.yyyy): ");
string input = Console.ReadLine();

if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
{
    string dayOfWeek = date.ToString("dddd", new CultureInfo("en-US"));
    string season;

    int month = date.Month;
    if (month == 12 || month == 1 || month == 2) season = "Winter";
    else if (month >= 3 && month <= 5) season = "Spring";
    else if (month >= 6 && month <= 8) season = "Summer";
    else season = "Autumn";

    Console.WriteLine($"{season} {dayOfWeek}");
}
else
{
    Console.WriteLine("Error: Invalid date format.");
}

// Exercise 6

Console.WriteLine("\nExercise 6");

Console.Write("Enter temperature: ");
double temperature = double.Parse(Console.ReadLine());

Console.WriteLine("1 - Fahrenheit to Celcius");
Console.WriteLine("2 - Celcius to Fahrenheit");
Console.Write("Enter your choice: ");
int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    double celsius = (temperature - 32) * 5 / 9;
    Console.WriteLine($"Temperature in Celcius: {celsius:F2}");
}
else if (choice == 2)
{
    double fahrenheit = (temperature * 9 / 5) + 32;
    Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}"); // F2 = setprecision s cpp, tipo 12.333 = 12.33
}
else
{
    Console.WriteLine("Error: wrong choice.");
}

// Exercise 7 

Console.WriteLine("\nExercise 7");

Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    int temp2 = num1;
    num1 = num2;
    num2 = temp2;
}

Console.WriteLine("Even numbers are:");
for (int i = num1; i <= num2; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}