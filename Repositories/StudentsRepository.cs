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
        private readonly List<Student> students = new()
        {
            new() { Id = 1, FullName = "David", Email = "David@gmail.com" },
            new() { Id = 2, FullName = "Mario", Email = "Mario@gmail.com" },
            new() { Id = 3, FullName = "Rita", Email = "Rita@gmail.com" },
            new() { Id = 1236, FullName = "Edgar Isai", Email = "isai@gmail.com" }
        };

        public List<Student> GetStudents()
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
