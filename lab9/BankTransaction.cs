using System;
namespace lab9
{
    class BankTransaction
    {
        public readonly DateTime Date;
        public readonly double Amount;
        public BankTransaction(double amount)
        {
            Date = DateTime.Now;
            Amount = amount;
        }
    }

}

