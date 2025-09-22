using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.Tests
{
    [TestClass]
    public class BankTests
    {
        [TestMethod]
        public void TestSumaBasica()
        {
            int a = 2;
            int b = 3;
            int resultado = a + b;
            Assert.AreEqual(5, resultado);
        }
    }
}