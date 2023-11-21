using Apps72.Dev.Data.DbMocker;
using Castle.Core;
using DemoUnitTest_xUnit_ConsoleAPP;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_MSTest
{
    [TestClass]
    public class BankAccount_Test
    {
        [TestMethod]
        public void Debit_WithValidBalance()
        {
            BankAccount b = new BankAccount("steve", 1000);
            b.Debit(200);
            Assert.AreEqual(800, b.Balance);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Credit_WithInvalidAmount()
        {
            BankAccount b = new BankAccount("steve", 1000);
            b.Credit(-200);
            Assert.AreEqual(800, b.Balance);
        }

        [TestMethod]     
        public void Credit_WithValidAmount()
        {
            BankAccount b = new BankAccount("steve", 1000);
            b.Credit(500);
            Assert.AreEqual(1500, b.Balance);
        }

        [TestMethod]
        public void Debit_WithMock()
        {
            var service = new Mock<IBankService>();
            service.Setup(srv => srv.GetBalance("yoyo")).Returns(1000);

            BankAccount b = new BankAccount(service.Object, "yoyo");
            b.Debit(200);
            Assert.AreEqual(800, b.Balance);
        }

        [TestMethod]
        public void Debit_WithDbMocker()
        {
            var cnx = new MockDbConnection();
            cnx.Mocks.When(c => c.HasValidSqlServerCommandText())
                .ReturnsTable(MockTable.WithColumns("Balance", "cname").AddRow(1000m, "steve"));

            IBankService service = new BankService(cnx);
            BankAccount c = new BankAccount(service, "steve");

            c.Debit(200);

            Assert.AreEqual(800, c.Balance);
        }
    }
}
