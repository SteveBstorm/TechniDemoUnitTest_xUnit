
namespace DemoUnitTest_xUnit_ConsoleAPP
{
    public interface IBankService
    {
        Dictionary<string, decimal> GetAllAcount();
        decimal GetBalance(string customerName);
    }
}