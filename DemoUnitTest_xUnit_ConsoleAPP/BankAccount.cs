using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_xUnit_ConsoleAPP
{
    public class BankAccount
    {
        private readonly string _customerName;
        private decimal _balance;

        public BankAccount(string customerName, decimal balance)
        {
            _customerName = customerName;
            _balance = balance;
        }

        public BankAccount(IBankService service, string customerName)
        {
            _customerName = customerName;
            _balance = service.GetBalance(customerName);
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        public void Debit(decimal amount)
        {
            if(amount <= _balance)
                _balance -= amount;
        }

        public void Credit(decimal amount)
        {
            if(amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            _balance += amount;
        }
    }
}
