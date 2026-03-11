using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories
{
    public class AlumnoNotasRepository: IAlumnoNotasRepository
    {
        public List<AlumnoNotas> AlumnoNota = new List<AlumnoNotas>()
        {
             new() { idAlumno = 1, idAsignatura = 1, nota = 100 },
             new() { idAlumno = 1, idAsignatura = 2, nota = 90 },
             new() { idAlumno = 1, idAsignatura = 3, nota = 100 },
             new() { idAlumno = 2, idAsignatura = 1, nota = 70 },
             new() { idAlumno = 2, idAsignatura = 2, nota = 65 },
             new() { idAlumno = 2, idAsignatura = 3, nota = 50 },
             new() { idAlumno = 1, idAsignatura = 1, nota = 100 },
             new() { idAlumno = 1, idAsignatura = 2, nota = 95 },
             new() { idAlumno = 1, idAsignatura = 3, nota = 95 },
        };

     

      
        public List<AlumnoNotas> GetAll()
        {
            return AlumnoNota;
        }
    }
}
