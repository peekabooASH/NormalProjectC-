using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            personapp aperson=new personapp();
            aperson.firstname = firstnameTextBox.Text;
            aperson.middlename = middlenameTextBox.Text;
            aperson.lastname = lastnameTextBox.Text;

            fullnameTextBox.Text=aperson.Getfullname();
            reversefullnameTextBox.Text = aperson.Getfullreversename();
        }
    }
}
