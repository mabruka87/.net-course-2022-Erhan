using Models;

namespace BankService
{
    public class Bank
    {
        public int CalcSalary(int income, int expen, int count, string post)
        {
            int salary;
            if (post == "владелец")
            {
                salary = Convert.ToInt32((income - expen) / count);
                return salary;
            }
            else
            {
                return 0;
            }

        }

        public void ConvertClitnToEmployee(Client client)
        {
            Employee employee = client;
            Client client1 = (Client)employee;
        }
    }
}