using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Storing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0,iteration=0,add1=0;
        List<string> array1 = new List<string>();
        private void addButton_Click(object sender, EventArgs e)
        {
            
            array1.Add(addText.Text); 
            addText.Text = "";
            label4.Text = Convert.ToString(++count);
            showListbox.Items.Clear();

            if (count == add1 )
            {
                foreach (var in2 in array1)
                {
                 showListbox.Items.Add(in2);
                }
            addButton.Enabled = false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            count = 0;add1=0;
            addButton.Enabled =true;
            showListbox.Items.Clear();
            addText.Text = "";
            label4.Text = Convert.ToString(count);
            array1 .Clear();
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showListbox.Items.Clear();
            if (count <= add1 )
            {
                foreach (var in2 in array1)
                {
                    showListbox.Items.Add(in2);
                }
                addButton.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            add1 = Convert.ToInt32(addData.Text);
            addData.Text = "";
        }
    }
}
