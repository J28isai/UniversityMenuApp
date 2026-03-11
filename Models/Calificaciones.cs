using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMenuApp.Models
{
    public class Calificaciones
    {
        public int IdAlumno { get; set; }

        public string NombreAlumno { get; set; }

        public int IdAsignatura { get; set; }

        public string NomAsignatura { get; set; }

        public int Nota { get; set; }

    }
}
