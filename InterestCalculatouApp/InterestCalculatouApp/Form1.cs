using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculatouApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (banknameComboBox.SelectedItem == "BRAC")
            {
              double total = 6;
                total *= Convert.ToDouble(timeTextBox.Text)*Convert.ToDouble(balanceTextBox.Text);
                label5.Text = (total/100).ToString();
            }
            else if (banknameComboBox.SelectedItem == "DBBL")
            {
                double total = 7 ;
                total *= Convert.ToDouble(timeTextBox.Text) * Convert.ToDouble(balanceTextBox.Text);
                label5.Text = (total / 100).ToString();
            }
            else if (banknameComboBox.SelectedItem == "HSBC")
            {
                double total =8 ;
                total *= Convert.ToDouble(timeTextBox.Text) * Convert.ToDouble(balanceTextBox.Text);
                label5.Text = (total / 100).ToString();
            }
            else
            {
                label5.Text = "Nothing is selected";
            }
        }
    }
}
