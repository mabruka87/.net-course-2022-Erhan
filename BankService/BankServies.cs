using Models;

namespace BankService
{
    public class Bank
    {
        public float CalcSalary(float income, float expen, int count)
        {
            float salary = Convert.ToInt32((income - expen) / count);
            return salary;

        }
        /*
       public void ConvertClitnToEmployee(Client? client)
        {
            //преобразовать клиента в сотрудника 
            Employee employee = new Employee();
            employee = client;
            client = (Сlient)employee;

        }
        */

    }
}