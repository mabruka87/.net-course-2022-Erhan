
namespace Service
{
    public class BankService
    {
        public float CalcSalary(float income, float expen, int count, string post)
        {
             float salary = Convert.ToInt32((income - expen) / count);
             return salary;
        }

      /*  public void ConvertClitnToEmployee(Client client)
        {
            Employee employee = client;
            Client client1 = (Client)employee;
        }*/
    }
}