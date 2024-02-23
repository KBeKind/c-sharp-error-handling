namespace ConsoleCalculator;

public class Calculator
{
    public int Calculate(int number1, int number2, string operation)
    {
     
        string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));


        if (nonNullOperation == "/")
        {
            try
            {
                return Divide(number1, number2);
            }
            catch(Exception ex)
            {
                Console.WriteLine("...logging...");
                //throw;
                throw new CalculationException(ex);
            }
       

            return Divide(number1, number2);
        }
        else
        {
            var ex = new CalculationOperationNotSupportedException(operation);
            throw ex;
        }
    }

    private int Divide(int number, int divisor) => number / divisor;
}

