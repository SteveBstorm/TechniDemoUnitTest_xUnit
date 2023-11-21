using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_xUnit_ConsoleAPP
{
    public class BankService : IBankService
    {
        private DbConnection _connection;

        private Dictionary<string, decimal> AccountInfo;

        public BankService()
        {
            AccountInfo = new Dictionary<string, decimal>();
            AccountInfo.Add("steve", 1000);
            AccountInfo.Add("loic", 2000);
        }

        public BankService(DbConnection connection)
        {
            _connection = connection;
        }

        public Dictionary<string, decimal> GetAllAcount()
        {
            return AccountInfo;
        }

        public decimal GetBalance(string customerName)
        {
           
            using(DbCommand cmd = _connection.CreateCommand())
            {
                cmd.CommandText = "SELECT Balance FROM Account WHERE cname = @cname";
                DbParameter p = cmd.CreateParameter();
                p.ParameterName = "cname";
                p.Value = customerName;
                cmd.Parameters.Add(p);

                return (decimal)cmd.ExecuteScalar();
            }
            //return AccountInfo[customerName];
        }
    }
}
