using ClosedXML.Excel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
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

    [ObservableProperty]
    public Student? seleccionado;

    public ObservableCollection<Student> Alumnos { get; } = new();


    [RelayCommand]
    public void Agregar()
    {
        Student nuevo = new Student
        {
            Id = Alumnos.Count + 1,
            FullName = FormFullName,
            Email = FormEmail
        };

        stdts.AddStudent(nuevo);

        Alumnos.Add(nuevo);

        FormFullName = "";
        FormEmail = "";
    }

    [RelayCommand]
    public void Borrar()
    {
        if (Seleccionado == null)
            return;

        stdts.DeleteStudent(Seleccionado);
        Alumnos.Remove(Seleccionado);
    }
    private void LoadStudents()
    {
        var lista = stdts.Students();
        Alumnos.Clear();
        foreach (var ce in lista)
            Alumnos.Add(ce);
    }

    [RelayCommand]
    private void ExportExel()
    {
        var dialog = new SaveFileDialog
        {
            Filter = "Exel Woorkbook (*.xlsx)|*.xlsx",
            FileName = "Studetnts.xlsx"

        };

        if (dialog.ShowDialog() != true)
            return;

        using var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add("Students");

        ws.Cell(1, 1).Value = "Id";
        ws.Cell(1, 2).Value = "Nombre";
        ws.Cell(1, 3).Value = "Email";
        ws.Row(1).Style.Font.Bold = true;

        int row = 2;
        foreach (var x in Alumnos) { 
        ws.Cell(row, 1).Value = x.Id;
        ws.Cell(row, 2).Value = x.FullName;
        ws.Cell(row, 3).Value = x.Email;
        row++;

        }
        ws.Columns().AdjustToContents();
        wb.SaveAs(dialog.FileName);



    }

}






