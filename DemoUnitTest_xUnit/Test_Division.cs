using DemoUnitTest_xUnit_ConsoleAPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_xUnit
{
    public class Test_Division
    {
        [Fact]
        public void Division_ResultOkValue()
        {
            Calcul c = new Calcul();
            Assert.Equal(2, c.Division(4, 2));
        }

        [Fact]
        public void Division_DividedByZero()
        {
            Calcul c = new Calcul();
            Assert.Throws<DivideByZeroException>(() => c.Division(4, 0));
        }

        [Fact]  
        public void Division_TypeDoubleExpected()
        {
            Calcul c = new Calcul();
            Assert.IsType<double>(c.Division(5, 2));
        }
    }
}
