using DemoUnitTest_xUnit_ConsoleAPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_xUnit
{
    public class Test_EstPair
    {
        [Theory]
        [InlineData(2)]
        [InlineData(42)]
        [InlineData(10)]
        public void EstPair_Valid(int value)
        {
            Calcul c = new Calcul();
            Assert.True(c.EstPair(value));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(17)]
        [InlineData(99)]
        public void EstPair_InValid(int value)
        {
            Calcul c = new Calcul();
            Assert.False(c.EstPair(value));
        }
    }
}
