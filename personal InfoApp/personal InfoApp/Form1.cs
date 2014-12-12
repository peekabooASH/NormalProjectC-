using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personal_InfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> info=new List<string>(); 
        private void saveButton_Click(object sender, EventArgs e)
        {
            info.Add(firstnameTextBox.Text);
            info.Add(lastnameTextBox.Text);
            info.Add(fathernameTextBox.Text);
            info.Add(mothernameTextBox.Text);
            info.Add(addressTextBox.Text);
            MessageBox.Show(@"Information is Saved");
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Your Full Name is: "+info[0]+" "+info[1]);
        }

        private void parentsnameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Your Father's Name is: " + info[2] + "\n" + @"Your Mother's Name is: " + info[3]);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Your Address is: " + info[4] );
        }

        private void showallButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Your Full Name is: "+info[0]+" "+info[1]+"\n"
                
                              +@"Your Father's Name is: " + info[2] + "\n" 
                              +@"Your Mother's Name is: " + info[3]+"\n"
                              +@"Your Address is: " + info[4] );

           firstnameTextBox.Text="";
           lastnameTextBox.Text="";
           fathernameTextBox.Text="";
           mothernameTextBox.Text="";
           addressTextBox.Text="";

        }
    }
}
