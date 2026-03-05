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

    

        public List<Student> students()
        {
            return new List<Student>
            {

                new() { Id = 1236, FullName = "Edgar isai", Email = "Isai26361gmail.com" },
                 new() { Id = 11566, FullName = "Carvajal", Email = "juanito.com" }


            };
        }
    }
}
