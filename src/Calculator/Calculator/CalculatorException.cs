using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorException :Exception
    {
        public CalculatorException()
        {
        }
        public CalculatorException(string message)
        :base(message)
        {
        }
        public CalculatorException(string message, Exception inner)
        :base(message, inner)
        {
        }
    }
}
