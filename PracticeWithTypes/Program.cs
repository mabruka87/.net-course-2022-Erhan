using BankService;
using Models;
using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.Name = "Tom";
        employee.Age = 25;
        employee.contract = "контракт 1";
        Console.WriteLine(employee.contract);
        AddContract(employee);
        Console.WriteLine(employee.contract);

        
        Currency currency = new Currency();
        ChangeCurrency(currency);
        
        Bank bank = new Bank();
        int result = bank.CalcSalary(100, 20, 2, "владелец");
        Console.WriteLine(result);
        Client client = new Client();
        bank.ConvertClitnToEmployee(client); 
        


    }
    static void AddContract(Employee employee)
    {
        employee.contract = "контракт 2";

        Console.WriteLine($"{employee.Name} {employee.Age} {employee.contract}");

        employee = new Employee { Name="Bob" ,Age = 25, contract="контракт 3"};
  
        Console.WriteLine($"{employee.Name} {employee.Age} {employee.contract}");
        
    }

    static void ChangeCurrency(Currency currency)
    {
        currency.CurrencyName = "Rub";
        currency.CurrencyPrice = 0.22;
        Console.WriteLine($"Валюта {currency.CurrencyName} курс {currency.CurrencyPrice}");
    }
}