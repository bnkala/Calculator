using CalculatorNS;
namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestNumbersValid()
        {
            Calculator cal = new Calculator();
            Assert.IsTrue(cal.IsInputValid("3","-","2"));
        }

        [TestMethod]
        public void TestOperatorValid()
        {
            Calculator cal = new Calculator();
            Assert.IsTrue(cal.IsInputValid("3","+","37"));
        }

        [TestMethod]
        public void TestOperatorInvalid()
        {
            Calculator cal = new Calculator();
            Assert.IsFalse(cal.IsInputValid("2",",","3"));
        }

        [TestMethod]
        public void TestNumbersInvalid1()
        {
            Calculator cal = new Calculator();
            Assert.IsFalse(cal.IsInputValid("w2", "+", "2"));
        }

        [TestMethod]
        public void TestNumbersInvalid2()
        {
            Calculator cal = new Calculator();
            Assert.IsFalse(cal.IsInputValid("23","*","s"));
        }

        [TestMethod]
        public void TestNumberDivideBy0()
        {
            Calculator cal = new Calculator();
            Assert.IsFalse(cal.IsInputValid("4", "/", "0"));
        }

        [TestMethod]
        public void TestAddResult()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(10, cal.GetResult("6","+","4"));
        }

        [TestMethod]
        public void TestSubtractResult()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(5, cal.GetResult("18","-","13"));
        }

        [TestMethod]
        public void TestMultiplyResult()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(30, cal.GetResult("6", "*", "5"));
        }

        [TestMethod]
        public void TestDivideResult()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(8, cal.GetResult("56", "/", "7"));
        }

        [TestMethod]
        public void TestFalseResult()
        {
            Calculator cal = new Calculator();
            Assert.AreNotEqual(6, cal.GetResult("2", "+", "3"));
        }

        [TestMethod]
        public void TestFalseResult2()
        {
            Calculator cal = new Calculator();
            Assert.AreNotEqual(9, cal.GetResult("23", "-", "14"));
        }

        [TestMethod]
        public void TestFalseResult3()
        {
            Calculator cal = new Calculator();
            Assert.AreNotEqual(13, cal.GetResult("7", "*", "2"));
        }

        [TestMethod]
        public void TestFalseResult4()
        {
            Calculator cal = new Calculator();
            Assert.AreNotEqual(3, cal.GetResult("23", "/", "7"));
        }

    }
}