namespace TekrarMovzular;

public class BankAccount
{
    public int accountNumber { get; }
    private double balance;
    public  double Balance { get; set; }

    public BankAccount(int bankacc)
    {
        accountNumber=bankacc;
    }
    public double Deposit(double balances)
    {
       return  Balance += balances;
       
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Balans:{Balance};Account bank:{accountNumber}");
    }
}
