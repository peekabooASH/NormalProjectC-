using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryKeepingApp
{
    public partial class EmployeeSalaryUI : Form
    {
        private string fileLocation = "employeeInfo.txt";
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string id = IdTextBox.Text;
            string name = nameTextBox.Text;
            string salaryAmount = salaryAmountTextBox.Text;
            string aRow = name + "," + id + "," + salaryAmount;

            FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(aRow);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            salaryInfoListBox.Items.Clear();
            double totalSalary = 0;
            while (!aStreamReader.EndOfStream)
            {
                string aRow = aStreamReader.ReadLine();
                char[] seperator = {','};
                string[] employeeInfo = aRow.Split(seperator);
                salaryInfoListBox.Items.Add(employeeInfo[0] + " " +employeeInfo[1] + " " + employeeInfo[2]);
                double salary = Convert.ToDouble(employeeInfo[2]);
                totalSalary += salary;
            }
            totalTextBox.Text = totalSalary.ToString();
            aStreamReader.Close();
        }
    }
}
