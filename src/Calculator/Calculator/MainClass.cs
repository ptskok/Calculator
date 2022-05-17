using System;
using System.IO;
using System.Text;

namespace Calculator
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string mathExpr = Console.ReadLine();
            Parser parser = new(new Lexer(mathExpr));
            Console.WriteLine(parser.Result());
        }
    }
}
