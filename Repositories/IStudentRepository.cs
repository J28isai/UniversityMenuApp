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
       List<Student> Students();
       public void AddStudent(Student student);

       public void DeleteStudent(Student student);

        
    }
}
