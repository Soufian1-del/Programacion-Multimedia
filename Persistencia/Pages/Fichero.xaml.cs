using System.Text.Json;

namespace Persistencia.Pages;

public partial class Fichero : ContentPage
{
	public Fichero()
	{
		InitializeComponent();
		cargarAlumnos();
	}
	private void cargarAlumnos()
	{
		List<Alumnos> alumnos = new List<Alumnos>();

        alumnos.Add(new Alumnos { nombre = "beatriz", apellido = "Martinez", edad = 25 });
        alumnos.Add(new Alumnos { nombre = "marta", apellido = "Martinez", edad = 25 });
        alumnos.Add(new Alumnos { nombre = "Ivan", apellido = "Martinez", edad = 25 });

		string path = FileSystem.AppDataDirectory;
		string fichero = Path.Combine(path, "alumnos.json");
		
		string jsonAlumnos = JsonSerializer.Serialize(alumnos);

		File.WriteAllText(fichero, jsonAlumnos);
	}
}