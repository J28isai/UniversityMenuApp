using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Repositories;
using UniversityMenuApp.Models;



namespace UniversityMenuApp.Services
{
    public partial class Servicio : ICalificacionesRepository
    {
        public readonly IStudentRepository stdrepo;

        public readonly ISubjetRepository sbjrepo;

        public readonly IAlumnoNotasRepository alurepo;

        public Servicio( IStudentRepository stdrepo, ISubjetRepository sbjrepo, IAlumnoNotasRepository alurepo)
        {
            this.stdrepo = stdrepo;
            this.sbjrepo = sbjrepo;
            this.alurepo = alurepo;
        }

        public List<Calificaciones> NotapAlumno(int idAlumno)
        {
            var alumnos = stdrepo.GetStudents();
            var materias = sbjrepo.GetSubjets();
            var notas = alurepo.GetAll();

            var resultado = (
                from nota in notas
                join alumno in alumnos on nota.idAlumno equals alumno.Id
                join materia in materias on nota.idAsignatura equals materia.idAsig
                select new Calificaciones
                {
                    IdAlumno = alumno.Id,
                    NombreAlumno = alumno.FullName,
                    IdAsignatura = materia.idAsig,
                    NomAsignatura = materia.nombre,
                    Nota = nota.nota,
                }
                ).ToList();

            return resultado.Where(x => x.IdAlumno == idAlumno).ToList();
        }

        public List<Calificaciones> NotapAsignatura(int idAsignatura)
        {
            var alumnos = stdrepo.GetStudents();
            var materias = sbjrepo.GetSubjets();
            var notas = alurepo.GetAll();

            var resultado = (
                from nota in notas
                join alumno in alumnos on nota.idAlumno equals alumno.Id
                join materia in materias on nota.idAsignatura equals materia.idAsig
                select new Calificaciones
                {
                    IdAlumno = alumno.Id,
                    NombreAlumno = alumno.FullName,
                    IdAsignatura = materia.idAsig,
                    NomAsignatura = materia.nombre,
                    Nota = nota.nota,
                }
                ).ToList();

            return resultado.Where(x => x.IdAsignatura == idAsignatura).ToList();
        }

        public double Promedio(int idAlumno)
        {
            var notasAlumno = alurepo.GetAll()
           .Where(x => x.idAlumno == idAlumno)
           .ToList();

            if (notasAlumno.Count == 0)
                return 0;

            return notasAlumno.Average(x => x.nota);

        }
    }
}
