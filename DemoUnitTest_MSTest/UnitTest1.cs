using DemoUnitTest_xUnit_ConsoleAPP;

namespace DemoUnitTest_MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calcul c = new Calcul();
            Assert.AreEqual(5, c.Addition(2, 3));
        }
    }
}