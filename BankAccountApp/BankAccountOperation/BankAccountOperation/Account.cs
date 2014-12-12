namespace BankAccountOperation
{
    public class Account
    {
        private string accountNumber;
        private string customerName;
        private double balance;

        public Account(string accountNumber, string customerName) : this()
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
        }

        public Account()
        {
            balance = 0;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public string Deposit(double amount)
        {
            balance = Balance + amount;
            return amount + " taka has been deposited."; 
        }

        public string Withdraw(double amount)
        {
            balance = Balance - amount;
            return amount + " taka has been withdrawn.";
        }
    }
}
