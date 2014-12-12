using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoLayerArchitectureApp.DLL.DAO;
using StudentInfoLayerArchitectureApp.DLL.Gateway;

namespace StudentInfoLayerArchitectureApp.BLL
{
    class StudentBLL
    {
        private StudentGateway aStudentGateway;

        public StudentBLL()
        {
            aStudentGateway = new StudentGateway();
        }

        public string Save(Student aStudent)
        {
            
            if (aStudent.Name == string.Empty || aStudent.Email == string.Empty || aStudent.Address == string.Empty)
            {
                return "Fill up all the Information";
            }
            return aStudentGateway.Save(aStudent);
        }

        public List<Student> GetAllDepartment()
        {
            return aStudentGateway.GetAllDepartment();
        }
    }
}
