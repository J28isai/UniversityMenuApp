using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMenuApp.Repositories
{
    public interface ICalificacionesRepository
    {
        public void NotapAlumno(int idAlumno, string nombreAlumno, int idAsignatura, string nombreAsignatura, int nota);

        public void NotapAsignatura();

        public void Promedio();
    }
}
