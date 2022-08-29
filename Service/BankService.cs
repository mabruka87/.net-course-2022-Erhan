
namespace Service
{
    public class BankService
    {
        public int CalcSalary(float income, float expen, int count)
        {
             int salary = Convert.ToInt32((income - expen) / count);
             return salary;
        }

      /*  public void ConvertClitnToEmployee(Client client)
        {
            Employee employee = client;
            Client client1 = (Client)employee;
        }*/
    }
}