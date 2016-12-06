using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAccount
{
    private double balance;
   
    public BankAccount()
    {
        balance = 0;
    }

    public BankAccount(double initialAmount)
    {
        balance = initialAmount;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public double Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return balance;
        }
        else
            return - 1.0;
    }

    public double QucickWithdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return balance;
        }
        else
            Console.WriteLine("You don't have enough money");
            return -1.0;
    }

}

class program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.Withdraw(40);
        account.QucickWithdraw(40);

    }
}
    

