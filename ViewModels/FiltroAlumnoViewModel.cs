using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;
using UniversityMenuApp.Repositories;
using UniversityMenuApp.Services;

namespace UniversityMenuApp.ViewModels
{
    public partial class FiltroAlumnoViewModel: ObservableObject
    {
        private readonly ICalificacionesRepository servicio;

        public FiltroAlumnoViewModel()
        {
            servicio = new Servicio ();

        }


        [ObservableProperty]
        public string idAlumno;

        [ObservableProperty]
        public string idAasignatura;

        public ObservableCollection<Calificaciones> calificaciones { get; } = new();
        

    }
}
