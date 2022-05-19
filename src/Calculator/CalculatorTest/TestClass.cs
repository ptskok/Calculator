using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            var parser = ParserBuilder("2+2");
            Assert.AreEqual(4,parser.Result());
        }
        [TestMethod]
        public void TestMethod2()
        {
            var parser = ParserBuilder("( 6 + 5 ) * 3");
            Assert.AreEqual(33,parser.Result());
        }
        [TestMethod]
        public void TestMethod3()
        {
            var parser = ParserBuilder("(6+5 )*3-2/2");
            Assert.AreEqual(32,parser.Result());
        }
        [TestMethod]
        public void TestMethod4()
        {
            var parser = ParserBuilder("3*3*3/ 2");
            Assert.AreEqual(13,parser.Result());
        }
        [TestMethod]
        public void TestMethod5()
        {
            var parser = ParserBuilder("(((3* 9)-9)    +9/3 )*2-1");
            Assert.AreEqual(41,parser.Result());
        }
        [TestMethod]
        public void TestMethod6()
        {
            var parser = ParserBuilder("(((3* 9)-9)    +9/3 )*2-1");
            Assert.AreEqual(41,parser.Result());
        }
        [TestMethod]
        public void TestMethod7()
        {
            var parser = ParserBuilder("(10-1)-(58-5)*3");
            Assert.AreEqual(-150,parser.Result());
        }
        [TestMethod]
        public void TestMethod8()
        {
            var parser = ParserBuilder("22-(5*4-10)+6");
            Assert.AreEqual(18,parser.Result());
        }
        [TestMethod]
        public void TestMethod9()
        {
            var parser = ParserBuilder("(5/4)*(5 +5+5)");
            Assert.AreEqual(15,parser.Result());
        }
        [TestMethod]
        public void TestMethod10()
        {
            var parser = ParserBuilder("9-(3/ 2 )/3 +1");
            Assert.AreEqual(10,parser.Result());
        }


        ///handle unary minus in the future
       /* [TestMethod]
        public void TestMethodX()
        {
            var parser = ParserBuilder("-2+3");
            Assert.AreEqual(1,parser.Result());
        }*/

        private static Parser ParserBuilder(string str)
        {
            return new Parser(new Lexer(str));
        }
    }
}
