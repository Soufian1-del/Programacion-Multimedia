using System.Text.Json;

namespace Persistencia.Pages;

public partial class Fichero : ContentPage
{
    string path, fichero;
    public Fichero()
    {
        InitializeComponent();
        cargarPagina();
    }

    private void cargarPagina()
    {
        path = FileSystem.AppDataDirectory;
        fichero = Path.Combine(path, "alumnos.json");

        if (Preferences.Get("hayalumnos", false))
        {
            muestraAlumnos();
        }
        else
            cargarAlumnos();

    }
    private void muestraAlumnos()
    {

        string json = File.ReadAllText(fichero);
        List<Alumnos> lista = JsonSerializer.Deserialize<List<Alumnos>>(json);

        foreach (Alumnos alumno in lista)
        {
            resultado.Text += $"{alumno.nombre} {alumno.apellido} {alumno.edad}" + Environment.NewLine;
        }
    }
    private void cargarAlumnos()
    {
        List<Alumnos> lista = new List<Alumnos>();

        lista.Add(new Alumnos { nombre = "Beatriz", apellido = "Martínez", edad = 25 });
        lista.Add(new Alumnos { nombre = "Marta", apellido = "Martín", edad = 22 });
        lista.Add(new Alumnos { nombre = "Iván", apellido = "García", edad = 19 });



        string json = JsonSerializer.Serialize(lista);

        File.WriteAllText(fichero, json);

        Preferences.Set("hayalumnos", true);
    }
}