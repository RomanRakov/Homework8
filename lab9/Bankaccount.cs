using System;
using System.Collections.Generic;
namespace lab9
{
    class Bankaccount
    {
        private uint number;
        private double balance;
        private TypeBankAccount type;
        internal Queue<BankTransaction> transactions = new Queue<BankTransaction>();
        public Bankaccount()
        {
            this.number = this.GenerateNumber();
        }
        public Bankaccount(double balance)
        {
            this.number = this.GenerateNumber();
            this.balance = balance;
        }
        public Bankaccount(TypeBankAccount type)
        {
            this.number = this.GenerateNumber();
            this.type = type;
        }
        public Bankaccount(double balance, TypeBankAccount type)
        {
            this.number = this.GenerateNumber();
            this.balance = balance;
            this.type = type;
        }
        private uint GenerateNumber()
        {
            return (uint)DateTime.Now.Ticks;
        }
        public void Transfer( Bankaccount получатель, double сумма) 
        { 
            if (сумма > balance) 
            { 
                Console.WriteLine("Недостаточно средств"); 
                return; 
            } 
            else 
            {
                balance -= сумма;
                получатель.balance += сумма; 
                transactions.Enqueue(new BankTransaction(сумма));
                Console.WriteLine("Перевод успешно выполнен");
            } 
        }
        public void Info()
        {
            Console.WriteLine($"Номер счета: {number}\nБаланс: {balance}\nТип счета: {type}\n");
        }
    }
}
