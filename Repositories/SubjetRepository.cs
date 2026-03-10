using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories
{
    public class SubjetRepository 
    {
        public List<Subjet> subjets = new List<Subjet>()
        {
             new() { idAsig = 1, nombre = "Matematicas" },
             new() { idAsig = 2, nombre = "Español" },
             new() { idAsig = 3, nombre = "sistemas" }
             
        };
    }
}
