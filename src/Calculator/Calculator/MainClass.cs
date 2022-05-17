using System;

namespace Calculator
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Parser parser = new(new Lexer());
            Console.WriteLine(parser.Result());
        }
    }
}
