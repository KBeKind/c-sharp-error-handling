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
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("...logging...");
                //throw;
                throw new ArithmeticException("An error occurred during calculation.", ex);
            }
            {
            
            
            }


            return Divide(number1, number2);
        }
        else
        {
            var ex = new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported.");
            throw ex;
        }
    }

    private int Divide(int number, int divisor) => number / divisor;
}

