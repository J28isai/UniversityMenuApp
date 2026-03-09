using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories
{
    public partial interface IStudentRepository
    {
       public List<Student> Students();
        void AddStudent(Student student);

        void DeleteStudent(Student student);
    }
}
