using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoLayerArchitectureApp.BLL;
using StudentInfoLayerArchitectureApp.DLL.DAO;

namespace StudentInfoLayerArchitectureApp
{
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
            ShowDataInGrid();
        }
        private List<Student> Students;
        private StudentBLL aStudentBll = new StudentBLL();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();

            aStudent.Name =nameTextBox.Text;
            aStudent.Email =emailTextBox.Text;
            aStudent.Address =addressTextBox.Text;

            string msg = aStudentBll.Save(aStudent);
            MessageBox.Show(msg);
            ShowDataInGrid();

        }

        private void ShowDataInGrid()
        {

            Students = aStudentBll.GetAllDepartment();
            dataGridView1.DataSource = Students;
        }
    }
}
