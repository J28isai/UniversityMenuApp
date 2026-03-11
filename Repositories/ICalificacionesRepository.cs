using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories
{
    public interface ICalificacionesRepository
    {
        public List<Calificaciones> NotapAlumno(int idAlumno);

        public List<Calificaciones> NotapAsignatura(int idAsignatura);

        public void Promedio(int idAlumno);
    }
}
