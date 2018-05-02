using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var accounts = new Dictionary<int, BankAccount>();

        string line;
        while ((line = Console.ReadLine()) != "End")
        {
            var tokens = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int accountId = int.Parse(tokens[1]);
            decimal amount = 0;
            switch (tokens[0])
            {
                case "Create":
                    Create(accounts, accountId);
                    break;
                case "Deposit":
                    amount = decimal.Parse(tokens[2]);
                    Deposit(accounts, accountId, amount);
                    break;
                case "Withdraw":
                    amount = decimal.Parse(tokens[2]);
                    Withdraw(accountId, accounts, amount);
                    break;
                case "Print":
                    Print(accounts, accountId);
                    break;
                default:
                    break;
            }
        }
    }

    private static void Print(Dictionary<int, BankAccount> accounts, int accountId)
    {
        if (!accounts.ContainsKey(accountId))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine($"Account ID{accountId}, balance {accounts[accountId].Balance:f2}");
        }
    }

    private static void Withdraw(int accountId, Dictionary<int, BankAccount> accounts, decimal amount)
    {
        if (!accounts.ContainsKey(accountId))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            if (amount > accounts[accountId].Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[accountId].Withdraw(amount);
            }
        }
    }

    private static void Deposit(Dictionary<int, BankAccount> accounts, int accountId, decimal amount)
    {
        if (!accounts.ContainsKey(accountId))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[accountId].Deposit(amount);
        }
    }

    private static void Create(Dictionary<int, BankAccount> accounts, int accountId)
    {
        if (!accounts.ContainsKey(accountId))
        {
            var acc = new BankAccount();
            acc.Id = accountId;
            accounts.Add(accountId, acc);
        }
        else
        {
            Console.WriteLine("Account already exists");
        }
    }
}