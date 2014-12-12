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

namespace HashtableSampleApp
{
    public partial class BookInfoUI : Form
    {
        public BookInfoUI()
        {
            InitializeComponent();
        }
        Hashtable bookinfo = new Hashtable();
        private void addButton_Click(object sender, EventArgs e)
        {
          
          bookinfo.Add(isbnTextBox.Text, bookdetailTextBox.Text);
            isbnTextBox.Text ="";
            bookdetailTextBox.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
         foreach (DictionaryEntry i in bookinfo)
            {
               
              if (bookinfo.Contains(isbnbookTextBox.Text))
                {
                    string bookDetail = (string)bookinfo[isbnbookTextBox.Text];
                    bookdetailstextBox.Text = "Book is Found.\n"+bookDetail;
                }
                else
                {
                    bookdetailstextBox.Text = "Book is not Found.";
                }
            }
       
        }
    }
}
