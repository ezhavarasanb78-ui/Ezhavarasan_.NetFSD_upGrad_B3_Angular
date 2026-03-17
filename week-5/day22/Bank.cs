using System;
using System.Collections.Generic;
using System.Text;

namespace day22
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }
    class BankAccount
    {
        private double balance;
        public BankAccount(double balance)
        {
            this.balance = balance;
        }
        public void Withdraw(double w)
        {
            if(w>balance)
            {
                throw new InsufficientBalanceException("Insufficient balance");
            }
                balance = balance - w;
            Console.WriteLine("withdraw successfully available balance : " + balance);
        }
    }
    internal class Bank
    {
        static void Main(string[] args)
        {
            double balance = 2000;
            double withdraw = 5000;
            BankAccount acc = new BankAccount(balance);
            try
            {
                acc.Withdraw(withdraw);
            }
            catch(InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Transaction Complete");
            }
        }
    }
}
