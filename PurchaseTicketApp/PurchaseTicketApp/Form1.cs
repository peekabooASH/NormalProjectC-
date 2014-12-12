using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseTicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int numberOfTickets = 0;
        private double unitPrice = 10;
        private string customerName = "";
        private double totalPrice = 0;

        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            numberOfTickets = Convert.ToInt16(numberOfTicketsTextBox.Text);
            customerName = customerNameTextBox.Text;
            totalPrice = unitPrice * numberOfTickets;
            MessageBox.Show(customerName + ", Please Pay " + totalPrice + " Taka to Purchase " + numberOfTickets + " Ticket(s)");

        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name: " + customerName + "\nUnit Price: " + unitPrice + "\n Total Price: " + totalPrice);
        }
    }
}
