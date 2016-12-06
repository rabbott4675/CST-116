using System;

public class Name
{
    private String first;
    private char initial;
    private String last;

    public Name(String f, String l)
    {
        first = f;
        last = l;
    }

    public string GetFirst()
    {
        return first;
    }
    public string GetLast()
    {
        return last;
    }

    public Name(String f, char i, String l) : this(f, l)
    {
        initial = i;
    }

    public override String ToString()
    {
        if (initial == '\u0000')
            return first + " " + last;
        else
            return first + " " + initial + " " + last;
    }

    
}

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
    }// Reduces balance by amount, if possible
    public double Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return balance;
        }
        else
            return -1.0;
    }
}

 public class SavingsAccount : BankAccount
    {
        private double interestRate;
        private double amount;

        public SavingsAccount(double amount, double rate) : base(amount)
        {
            this.amount = amount;
            interestRate = rate;
        }

        public double GetIntrestRate()
        {
            return interestRate;
        }

        public double GetAmount()
        {
            return amount;
        }

        public void PostInterest()
        {
            double balance = GetBalance();
            double interest = interestRate / 100 * balance;
            Deposit(interest);
        }
    }


public class TestPerson
{
    public static void Main()
    {
        Name name = new Name("Ben", "Franklin");
        SavingsAccount savings = new SavingsAccount(500.00, 4.0);
        String s = "The account of " + name + " is " + savings.GetAmount() + " at " + savings.GetIntrestRate() + " percent interest.";
        Console.WriteLine(s);
        s = "The account of " + name + " is " + savings;
        Console.WriteLine(s);
        s = "The account of " + name.GetLast() + ", " + name.GetFirst() + " is " + savings.GetAmount() + " at " + savings.GetIntrestRate() + " percent interest.";
        Console.WriteLine(s);

    }
}