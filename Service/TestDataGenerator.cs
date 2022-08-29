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
        public static List<Client> GetCLientList()
        {
            var clients = new List<Client>();

            for (int i = 0; i < 1000; i++)
            {
                clients.Add(new Client
                {
                    Name = "Name_" + i,
                });
            }

            return clients;
        }
    }
}
