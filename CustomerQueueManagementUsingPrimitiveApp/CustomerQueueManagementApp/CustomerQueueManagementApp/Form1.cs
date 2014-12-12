using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementApp
{
    public partial class CustomerQueueManagementUI : Form
    {
        public CustomerQueueManagementUI()
        {
            InitializeComponent();
        }

        Queue<string> complainQueue = new Queue<string>();
        
        int count=1;     
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            complainQueue.Enqueue(count.ToString());
            complainQueue.Enqueue(enquNameTextBox.Text);
            complainQueue.Enqueue(enquComplainTextBox.Text);

            ListViewItem items = new ListViewItem(count.ToString());
            items.SubItems.Add(enquNameTextBox.Text);
            items.SubItems.Add(enquComplainTextBox.Text);
            queueList.Items.Add(items);

            enquNameTextBox.Text = "";
            enquComplainTextBox.Text = "";
            
            count++;
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (complainQueue.Count !=0)
            {
                dequSerialTextBox.Text = complainQueue.Dequeue();
                dequNameTextBox.Text = complainQueue.Dequeue();
                dequCompTextBox.Text = complainQueue.Dequeue();
            }

            else
            {
                dequSerialTextBox.Text = "";
                dequNameTextBox.Text = "";
                dequCompTextBox.Text = "";
                count = 1;
                MessageBox.Show("There is no Complaints!");
            }

            if (queueList.Items.Count!=0)
            {
                queueList.Items.RemoveAt(0);
            }
            
        }

        
    }
}
