using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TestDataGenerator
    {
        Random rnd = new Random();
        public List<Client> GetClientList()
        {
            var clientList = new List<Client>();

            for (int i = 0; i < 1000; i++)
            {
                clientList.Add(new Client
                {
                    Name = "Name_client_" + i
                });
            }
            return clientList;
        }

        public Dictionary<int, Client> GetClientDyctionar()
        {
            var client = new Dictionary<int, Client>();

            for (int i = 0; i < 1000; i++)
            {
                client.Add(
                i,
                new Client
                {
                    Name = "Name_" + i,
                    Telefon = i,
                    Age = rnd.Next(18, 90)
                });
            }

            return client;
        }

        public List<Employee> GetEmployeeList()
        {
            var employees = new List<Employee>();

            for (int i = 0; i < 1000; i++)
            {
                employees.Add(new Employee
                {
                    Name = "Name_emloyee_" + i,
                    Salary = rnd.Next(1000, 3000)
                });
            }
            return employees;
        }
    }
}
