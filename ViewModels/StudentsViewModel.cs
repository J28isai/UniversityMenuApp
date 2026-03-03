using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.ViewModels;

public partial class StudentsViewModel : ObservableObject 
{

    public StudentsViewModel() { 
    load();
    
    }  

    [ObservableProperty]
    private string formFullName = "";
    [ObservableProperty]
    public string formEmail = "";

    public ObservableCollection<Student> Alumnos { get; } = new();

    private void load()
    {
        Alumnos.Clear();
        Alumnos.Add(new Student { Id = 1236, FullName = "Edgar isai", Email = "Isai26361gmail.com" });
    }





}
