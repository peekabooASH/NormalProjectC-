using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using StudentInfoLayerArchitectureApp.DLL.DAO;

namespace StudentInfoLayerArchitectureApp.DLL.Gateway
{
    class StudentGateway
    {
        private SqlConnection connection;
        public StudentGateway()
        {
            string conn = @"server=NADIM-PC; database=AbcUniversity; Trusted_Connection=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }
        public string Save(Student aStudent)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Student VALUES('{0}','{1}','{2}')", aStudent.Name,
                aStudent.Email, aStudent.Address);

            SqlCommand command = new SqlCommand(query, connection);
            int affectedRows = command.ExecuteNonQuery();

            connection.Close();

            if(affectedRows>0)
            return "Data Inserted";
            else
            return "Data is Not inserted";

        }

        public  List<Student> GetAllDepartment()
        {
            connection.Open();

            string query = string.Format("SELECT * FROM t_Student");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            List<Student> students = new List<Student>();
            int count = 0;
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent = new Student();
                    aStudent.StudentID = ++count;
                    aStudent.Name = aReader[0].ToString();
                    aStudent.Email = aReader[1].ToString();
                    aStudent.Address = aReader[2].ToString();
                    students.Add(aStudent);
                }
            }
            connection.Close();
            return students;
        }
    }
}
