using ConsoleCalculator;
using static System.Console;

// Note: Additional input validation omitted for brevity

WriteLine("Enter first number");
int number1 = int.Parse(ReadLine()!);

WriteLine("Enter second number");
int number2 = int.Parse(ReadLine()!);

WriteLine("Enter operation");
string operation = ReadLine()!.ToUpperInvariant();

try
{
    var calculator = new Calculator();
    int result = calculator.Calculate(number1, number2, operation);
    DisplayResult(result);
}
catch (ArgumentNullException ex) when (ex.ParamName == "operation")
{
    WriteLine($"Operation was not provided. {ex}");
}
catch (ArgumentNullException ex)
{
    WriteLine($"An argument was null. {ex}");
}
catch (ArgumentOutOfRangeException ex){
    WriteLine($"Operation is not supported. {ex}");
}
catch (Exception ex)
{
   WriteLine($"Something went wrong. {ex}");
}
finally
{
    WriteLine("...finally...");
}

WriteLine("\nPress enter to exit.");
ReadLine();
    

static void DisplayResult(int result) => WriteLine($"Result is: {result}");