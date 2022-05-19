using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Lexer
    {
        private int _current;
        private string _mathExpr;
        private int _idx;

        public Lexer(string mathExpr)
        {
            _mathExpr = mathExpr;
            _idx = 0;
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
                case '\n':
                case '\r':
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
                case -1:
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
            if (_idx == _mathExpr.Length )
            {
                _current = -1;
            }
            else
            { 
                _current = _mathExpr[_idx];
                _idx++;
            }

        }
    }
}
