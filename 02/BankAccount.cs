using System;

namespace _02
{
    class BankAccount
    {

        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private decimal borrowingRate;
        public decimal BorrowingRate
        {
            get { return borrowingRate; }
            set { borrowingRate = value; }
        }

        private decimal savingsRate;

        public BankAccount(decimal balance, decimal borrowingRate, decimal savingsRate)
        {
            this.balance = balance;
            this.borrowingRate = borrowingRate;
            this.savingsRate = savingsRate;
        }

        public decimal SavingsRate
        {
            get { return savingsRate; }
            set { savingsRate = value; }
        }


        public void Withdraw (decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("No negative values allowed");
            }
            if (balance - amount < -100000)
            {
                throw new ArgumentException("the balance must never be less than -100,000");
            }
            balance -= amount;
        }
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("No negative values allowed");
            }
            if (amount + balance > 250000)
            {
                throw new ArgumentException("the balance must never exceed 250,000");
            }

            balance += amount;
        }

        public void AccrueInterest ()
        {
            if (balance > 0)
            {
                balance += balance * savingsRate;
            }
            else
            {
                balance -= Math.Abs(balance) * borrowingRate; 
            }
        }
    }
}
