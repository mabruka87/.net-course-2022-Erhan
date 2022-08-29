using Models;
using Service;

internal class Program
{
    private static void Main(string[] args)
    {
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

        Client client = new Client();
        //bank.ConvertClitnToEmployee(client); 

        //var clientList = GetCLientList();

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