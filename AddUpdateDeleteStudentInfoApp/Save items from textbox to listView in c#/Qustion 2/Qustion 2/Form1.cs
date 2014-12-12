using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Qustion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        // Save new items to listView (text from input nametxt, numbertxt and emailtxt)
        //  Save items whenever Save Button is clicked
        private void Savebtn_Click(object sender, EventArgs e)
        {
            string[] row = { nametxt.Text, numbertxt.Text, emailtxt.Text };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            clear();
            Updatebtn.Enabled = true;
            Cancelbtn.Enabled = true;
            Addnewbtn.Enabled = true;
            Savebtn.Enabled = false;
        }//end method Savebtn_Click

        //take items to textboxes as it was before to update 
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = listView1.Items[0];
            nametxt.Text = item.SubItems[0].Text;
            numbertxt.Text = item.SubItems[1].Text;
            emailtxt.Text = item.SubItems[2].Text;


            Updatebtn.Enabled = true;
            Cancelbtn.Enabled = true;
            Addnewbtn.Enabled = false;
            Savebtn.Enabled = false;
        }// end method listView1_DoubleClick

        //update items in listView
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in listView1.Items)
            {

                item.Text = nametxt.Text;
                item.SubItems[1].Text = numbertxt.Text;
                item.SubItems[2].Text = emailtxt.Text;
              
              }
            clear();
            Updatebtn.Enabled = false;
            Cancelbtn.Enabled = true;
            Addnewbtn.Enabled = true;
            Savebtn.Enabled = false;

        }//end method  Updatebtn_Click

        // exit application        
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nametxt.Focus();
            Updatebtn.Enabled = false;
            Cancelbtn.Enabled = false;
            Addnewbtn.Enabled = false;
            Savebtn.Enabled = true;

        }
        //clear textbox
        void clear()
        {
            nametxt.Clear();
            numbertxt.Clear();
            emailtxt.Clear();
        }
        //add new data
        private void Addnewbtn_Click(object sender, EventArgs e)
        {
            clear();
            nametxt.Focus();
            Updatebtn.Enabled = false;
            Cancelbtn.Enabled = true;
            Addnewbtn.Enabled = false;
            Savebtn.Enabled = true;

        }

    }//end class
}//end namespace

