
interface ICurrency
{
    void Convert();
    void Cent();
}

abstract class Currency : ICurrency
{
    public double Amount { get; set; }
    public double ExchangeRate { get; set; }

    public abstract void Convert();

    public abstract void Cent();
}

class Dollar : Currency
{
    public Dollar(double amount, double exchangeRate)
    {
        Amount = amount;
        ExchangeRate = exchangeRate;
    }

    public override void Convert()
    {
        Console.WriteLine($"{Amount} Dollars = {Amount * ExchangeRate} Rub");
    }

    public override void Cent()
    {
        Console.WriteLine($"Cents: {Amount * 100}");
    }
}

class Euro : Currency
{
    public Euro(double amount, double exchangeRate)
    {
        Amount = amount;
        ExchangeRate = exchangeRate;
    }

    public override void Convert()
    {
        Console.WriteLine($"{Amount} Euros = {Amount * ExchangeRate} Rub");
    }

    public override void Cent()
    {
        Console.WriteLine($"Eurocents: {Amount * 100}");
    }
}

class Pound : Currency
{
    public Pound(double amount, double exchangeRate)
    {
        Amount = amount;
        ExchangeRate = exchangeRate;
    }

    public override void Convert()
    {
        Console.WriteLine($"{Amount} Pounds = {Amount * ExchangeRate} Rub");
    }

    public override void Cent()
    {
        Console.WriteLine($"Pence: {Amount * 100}");
    }
}

class Purse
{
    private Currency[] currencies;

    public Purse(int size)
    {
        currencies = new Currency[size];
    }

    public void AddCurrency(Currency currency, int index)
    {
        currencies[index] = currency;
    }

    public void DisplayPurse()
    {
        foreach (var currency in currencies)
        {
            currency.Convert();
            currency.Cent();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Purse purse = new Purse(3);
        purse.AddCurrency(new Dollar(92.42, 100), 0);
        purse.AddCurrency(new Euro(100.13, 100), 1);
        purse.AddCurrency(new Pound(117.07, 100), 2);

        purse.DisplayPurse();
    }
}
