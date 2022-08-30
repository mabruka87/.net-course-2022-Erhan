
using Models;

namespace Service
{
    public class BankService
    {
        public int CalcSalary(float income, float expen, int count)
        {
            int salary = Convert.ToInt32((income - expen) / count);
            return salary;
        }

        public Employee ConvertClitnToEmployee(Client client)
        {
            return new Employee
            {
                Name = client.Name
            };
        }
    }
}