// See https://aka.ms/new-console-template for more information

namespace _05 // Note: actual namespace depends on the project name.
{
    internal partial class Program
    {
        class BankAccount
        {
            private decimal Balance { get; set; }

            public BankAccount(decimal balance)
            {
                Balance = balance;
                if (Balance < 0)
                {
                    throw new InsufficientFundsException();
                }
            }

            public void Deposit (decimal amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentException();
                }
                Balance += amount;
            }

            public void Withdraw (decimal amount)
            {
                if (Balance - amount < 0)
                {
                    throw new InsufficientFundsException();
                }
                Balance -= amount;
            }
        }

    }
}

