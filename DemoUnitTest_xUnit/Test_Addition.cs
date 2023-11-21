using DemoUnitTest_xUnit_ConsoleAPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_xUnit
{
    public class Test_Addition
    {
        [Fact]
        public void AdditionAvecEntierValide()
        {
            Calcul c = new Calcul();
            int result = c.Addition(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void AdditionValeurLimite()
        {
            Calcul c = new Calcul();

            Assert.Throws<OverflowException>(
                () => c.Addition(int.MaxValue, 10));
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(55,32, 87)]
        [InlineData(1,42, 43)]
        public void AdditionMultipleValue(int nb1, int nb2, object expected)
        {
            Calcul c = new Calcul();
            Assert.Equal(expected, c.Addition(nb1, nb2));
        }

    }
}
