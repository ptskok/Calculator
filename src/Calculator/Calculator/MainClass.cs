using System;

namespace Calculator
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Lexer lexer = new();
            try
            {
                lexer.NextToken();
                lexer.NextToken();
                lexer.NextToken();
                lexer.NextToken();
                lexer.NextToken();
                lexer.NextToken();
                lexer.NextToken();
                lexer.NextToken();
                lexer.NextToken();
                lexer.NextToken();
                lexer.NextToken();
            }
            catch (CalculatorException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
