using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Lexer
    {
        private int _current;

        public Lexer()
        {
            Consume();
        }

        public Token NextToken()
        {
            if (Char.IsDigit((char) _current))
            {
                return HandleNumber();
            }
        }

        private Token HandleNumber()
        {
            throw new NotImplementedException();
        }
        private void Consume()
        {
            _current = Console.Read();
        }
    }
}
