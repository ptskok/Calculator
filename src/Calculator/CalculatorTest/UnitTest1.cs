using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Parser parser = new(new Lexer());
            Console.WriteLine("2+2");
            Console.WriteLine(parser.Result());
        }
    }
}
