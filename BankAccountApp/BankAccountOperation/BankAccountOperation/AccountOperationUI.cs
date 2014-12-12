using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BankAccountOperation
{
    public partial class AccountOperationUI : Form
    {
        private Account myAccount = null;
        private double amount = 0;
        private string userMessage = "";

        public AccountOperationUI()
        {
            InitializeComponent();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (myAccount != null)
            {
                userMessage = myAccount.CustomerName + ", your account number: " + myAccount.AccountNumber +
                              " and it's balance: " + myAccount.Balance;
            }
            else
            {
                userMessage = "Account is not created.";
            }
            MessageBox.Show(userMessage);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection("Data Source=LALIT-PC;Initial Catalog=BankDB;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();

            da.InsertCommand = new SqlCommand("INSERT INTO Banktable VALUES(@AccountNumber, @CustomerName)", cs);

            da.InsertCommand.Parameters.Add("@AccountNumber", SqlDbType.VarChar).Value = accountNumberTextBox.Text;
            da.InsertCommand.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = customerNameTextBox.Text;

            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
            
            myAccount = new Account(accountNumberTextBox.Text, customerNameTextBox.Text);

            userMessage = "Account has been created.\nAccount number: " + myAccount.AccountNumber + "\nCustomer name: " +
                                myAccount.CustomerName;
            MessageBox.Show(userMessage);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            userMessage = myAccount.Deposit(amount);
            MessageBox.Show(userMessage);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            userMessage = myAccount.Withdraw(amount);
            MessageBox.Show(userMessage);

        }
    }
}
