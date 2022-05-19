/*
Expr->Mul { "+" | "-"Mul}
Mul->Term { "*" | "/"Term}
Term->number | "("Expr ")"
*/
namespace Calculator
{
    public class Parser
    {
        private Token _current;
        private readonly Lexer _lexer;
        public Parser(Lexer lexer)
        {
            _lexer = lexer;
        }
        public int Result()
        {
            Consume();
            return Expr();
        }

        private int Mul()
        {
            //Mul->Term { "*" | "/"Term}
            int value = Term();
            while (_current.Type == TokenType.Multiplication || _current.Type == TokenType.Division)
            {
                switch (_current.Type)
                {
                    case TokenType.Division:
                        Consume();
                        value /= Term();
                        break;
                    case TokenType.Multiplication:
                        Consume();
                        value *= Term();
                        break;
                    default:
                        throw new CalculatorException("Unexpected behaviour!");
                }
            }
            return value;
        }

        private int Term()
        {
            //Term -> number | "("Expr")"
            int value;
            switch (_current.Type)
            {
                case TokenType.LeftBracket:
                    Consume();
                    value = Expr();
                    if (_current.Type != TokenType.RightBracket)
                    {
                        throw new CalculatorException("Syntax error! Expected ) but got [" + _current.Type + "]");
                    }
                    Consume();
                    break;
                case TokenType.Number:
                //case TokenType.Minus:
                    value = int.Parse(_current.Attribute);
                    Consume();
                    break;
                default:
                    throw new CalculatorException("Unexpected behaviour! - ["+_current.Type + "]");
            }
            return value;
        }

        private int Expr()
        {
            //Expr->Mul { "+" | "-"Mul}
            int value = Mul();
            while (_current.Type == TokenType.Plus || _current.Type == TokenType.Minus)
            {
                switch (_current.Type)
                {
                    case TokenType.Plus:
                        Consume();
                        value += Mul();
                        break;
                    case TokenType.Minus:
                        Consume();
                        value -= Mul();
                        break;
                    default:
                        throw new CalculatorException("Unexpected behaviour!");
                }
            }
            return value;
        }
        private void Consume()
        {
            _current = _lexer.NextToken();
        }
    }
}
