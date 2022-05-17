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
            if (char.IsDigit((char) _current))
            {
                return HandleNumber();
            }

            switch (_current)
            {
                case ' ':
                case '\t':
                    return NextToken();
                case '+':
                    Consume();
                    return new Token(TokenType.Plus);
                case '-':
                    Consume();
                    return new Token(TokenType.Minus);
                case '*':
                    Consume();
                    return new Token(TokenType.Multiplication);
                case '/':
                    Consume();
                    return new Token(TokenType.Division);
                case '(':
                    Consume();
                    return new Token(TokenType.LeftBracket);
                case ')':
                    Consume();
                    return new Token(TokenType.RightBracket);
                case '\n':
                case '\r':
                    return new Token(TokenType.EOF);
                default:
                    throw new CalculatorException("Unexpected symbol! ["+_current+"]");
            }
        }

        private Token HandleNumber()
        {
            StringBuilder stringBuilder = new();
            while (char.IsDigit((char)_current))
            {
                stringBuilder.Append((char) _current);
                Consume();
            }
            return new Token(TokenType.Number,stringBuilder.ToString());
        }
        private void Consume()
        {
            _current = Console.Read();
        }
    }
}
