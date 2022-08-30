using Models;
using Service;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    { /*
        Employee employee = new Employee { Name = "Tom", Age = 25, Contract = "Контракт 1" };
        ChangeContract(ref employee);
        Console.WriteLine(employee.Contract);

        Currency currency = new Currency();
        currency.CurrencyName = "Valuta";
        currency.CurrencyPrice = 10.5;
        Console.WriteLine($"Валюта {currency.CurrencyName} курс {currency.CurrencyPrice}");
        ChangeCurrency( ref currency);
        Console.WriteLine($"Валюта {currency.CurrencyName} курс {currency.CurrencyPrice}");


        BankService bank = new BankService();
        float result = bank.CalcSalary(100.20F, 20.30f, 2);
        Console.WriteLine(result);

        /*Client client = new Client();
        bank.ConvertClitnToEmployee(client);*/

        TestDataGenerator testDataGenerator = new TestDataGenerator();
        var listClient = testDataGenerator.GetClientList();
        var DictionaryClient = testDataGenerator.GetClientDyctionar();
        var ListEmployee = testDataGenerator.GetEmployeeList();

        var sw = new Stopwatch();
        sw.Start();
        foreach (var item in DictionaryClient)
        {
            if (item.Value.Telefon == 5)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value.Name);
                break;
            }
        }
        sw.Stop();
        var res = sw.ElapsedTicks;
        Console.WriteLine(res);
        sw.Restart();

        foreach (var item in DictionaryClient)
        {
            if (item.Value.Age < 50)
            {
                Console.WriteLine($" {item.Key} имя {item.Value.Name} возраст  {item.Value.Age}");
            }

        }

        var SortListEmployee = ListEmployee.OrderBy(employee => employee.Salary);
        var SalaryMin = SortListEmployee.First().Salary;
        Console.WriteLine(SalaryMin);

        sw.Start();
        var LastFirstDictionary = DictionaryClient.OrderByDescending(x => x.Key).FirstOrDefault();
        Console.WriteLine($"Последний элемент коллекции {LastFirstDictionary} ");
        var res_FirstOfDefault = sw.ElapsedTicks;
        sw.Restart();

        sw.Start();
        foreach (var item in DictionaryClient)
        {
            if (item.Key == DictionaryClient.Count - 1)
            {
                Console.WriteLine($"Последний элемент коллекции {item.Key} ");
            }
        }
        var res_Foreach = sw.ElapsedTicks;
        sw.Restart();

        Console.WriteLine($"res_FirstOfDefault {res_FirstOfDefault} res_Foreach {res_Foreach}");



    }

    static void ChangeContract(ref Employee employee)
    {
        employee.Contract = "контракт 2";
    }

    static void ChangeCurrency( ref Currency currency)
    {
        currency.CurrencyName = "Rub";
        currency.CurrencyPrice = 0.22;
        Console.WriteLine($"Валюта метод {currency.CurrencyName} курс {currency.CurrencyPrice}");
    }
}