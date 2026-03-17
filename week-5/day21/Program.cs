namespace day21
{
    class BankAccount
    {
        private int Number;
        private double balance;

        public int Accountnumber
        {
            get { return Number; }
            set { Number = value; }
        }
        public double Balance
        {
            get { return balance; }
        }
        public void Deposit(double amount)
        { 
            if(amount<=0)
            {
                Console.WriteLine("Invalid Deposit amount");
            }
            else
            {
                balance = balance + amount;
                Console.WriteLine("amount Deposited " + amount);
                Console.WriteLine("available balance " + balance);
            }

        }
        public void withdraw(double amount)
        {
            if(amount<=0)
            {
                Console.WriteLine("Invalid withdraw amount");
            }
            else if(amount>balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("amount withdraw " + amount);
                Console.WriteLine("available balance " + balance);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
            ba.Accountnumber = 78;
            ba.Deposit(10000);
            ba.withdraw(2000);
        }
    }
}
