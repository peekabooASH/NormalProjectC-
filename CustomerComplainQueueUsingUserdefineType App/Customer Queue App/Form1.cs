using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Queue_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<Customer> aCustomer = new Queue<Customer>();
         int i = 1;
        private void buttonEnqueue_Click(object sender, EventArgs e)
        {
            if (nameText.Text != "" && complainText.Text != "")
            {
                Customer customer1 = new Customer();

                customer1.serial = i++.ToString();
                customer1.name = nameText.Text;
                customer1.complain = complainText.Text;
                aCustomer.Enqueue(customer1);
                listView1.Items.Add(

                    new ListViewItem(new[] {customer1.serial, customer1.name, customer1.complain})
                    );
                nameText.Text = string.Empty;
                complainText.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please,Enter some value.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View=View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Serial No", 70);
            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Complain", 315);
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (aCustomer.Count > 0) { 
            serialText.Text = listView1.Items[0].SubItems[0].Text;
            nameText2.Text = listView1.Items[0].SubItems[1].Text;
            complainText2.Text = listView1.Items[0].SubItems[2].Text;


            aCustomer.Dequeue();

            listView1.Items.Clear();
                foreach (Customer sublist in aCustomer)
                {
                    listView1.Items.Add(
                        new ListViewItem(new[] { sublist.serial, sublist.name, sublist.complain })
                        );
                }
            }
            else
            {
                i = 1;
                nameText2.Text = "";
                serialText.Text = "";
                complainText2.Text = "";
                MessageBox.Show("Sorry,Queue is empty.");
            }
               
        }
    }
}
