using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
	public class CalculationException: Exception
	{

		private const string DefaultMessage = "An error occurred during calculation.  Ensure that the operator and all values are valid.";
		public CalculationException() : base(DefaultMessage) { }

		public CalculationException(string message) : base(message) { }

		public CalculationException(Exception innerException) : base(DefaultMessage, innerException) { }

		public CalculationException(string message, Exception innerException) : base(message, innerException) { }

	}
}
