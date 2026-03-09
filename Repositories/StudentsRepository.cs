using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories
{
    public class StudentsRepository : IStudentRepository
    {

   

         public List<Student> students = new List<Student>()
              {
                  new() { Id = 1236, FullName = "Edgar Isai", Email = "isai@gmail.com" }
               };


        public List<Student> Students()
            {
                return students;
            }

         public void AddStudent(Student student)
              {
                    students.Add(student);
            }

        public void DeleteStudent(Student student)
        {
                students.Remove(student);
        }
    }
}
