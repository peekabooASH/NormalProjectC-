using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Show_each_Element
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int[] arr = { 4, 5, 4, 2, 4, 2, 3 };
            int[] count = new int[100];
            string[] index = new string[100];
            for (int i = 0; i < 100; i++)
            {
                index[i] = "";
                count[i] = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                count[arr[i]]++;
                index[arr[i]] += i + " ";
            } 
            listBox2.Items.Clear();
            for (int i = 0; i < 7; i++)
            {
                listBox2.Items.Add(arr[i]);
            }
            listBox1.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (count[i] > 0)
                {
                    listBox1.Items.Add("Item: " + i + ", Count: " + count[i] + ", Index: " + index[i]);
                }
            }
        }
    }
}
