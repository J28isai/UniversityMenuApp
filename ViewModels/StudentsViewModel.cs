using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using UniversityMenuApp.Models;
using UniversityMenuApp.Repositories;

namespace UniversityMenuApp.ViewModels;

public partial class StudentsViewModel : ObservableObject
{

    private readonly IStudentRepository stdts;

    public StudentsViewModel()
    {
        stdts = new StudentsRepository();      
        LoadStudents();                        
    }

    [ObservableProperty]
    private string formFullName = "";

    [ObservableProperty]
    private string formEmail = "";

    public ObservableCollection<Student> Alumnos { get; } = new();

    private void LoadStudents()
    {
        var lista = stdts.students();
        Alumnos.Clear();
        foreach (var ce in lista)
            Alumnos.Add(ce);
    }
}





