using Collection;
using Microsoft.Maui.Controls.Shapes;
using System.Text.Json;
using Path = System.IO.Path;


namespace Citas.Pages;

public partial class solicitar : ContentPage
{
    string path, fichero;

    public solicitar()
	{
		InitializeComponent();
        this.listaEspecialidades.ItemsSource = cargarEspecialidades();
	}

    private void listaEspecialidades_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private List<Especialidades> cargarEspecialidades()
    {
        List<Especialidades> especialidades = new List<Especialidades>();

        especialidades.Add(new Especialidades() { Imagen = "cardiologia.svg", Especialidad = "Cardiologia", Nombre = "Dra. Laura Martin", Dias = 25 });
        especialidades.Add(new Especialidades() { Imagen = "dermatologia.svg", Especialidad = "Dermatologia", Nombre = "Dr. Javier Ruiz", Dias = 40 });
        especialidades.Add(new Especialidades() { Imagen = "ginecologia.svg", Especialidad = "Ginecologia", Nombre = "Dra. Elena Gomez", Dias = 32 });
        especialidades.Add(new Especialidades() { Imagen = "neurologia.svg", Especialidad = "Neurologia", Nombre = "Dr. Carlos navarro", Dias = 55 });
        especialidades.Add(new Especialidades() { Imagen = "oftalmologia.svg", Especialidad = "Oftalmologia", Nombre = "Dra. Marta Sanchéz", Dias = 7 });
        especialidades.Add(new Especialidades() { Imagen = "otorrino.svg", Especialidad = "Otorrinolaringolojilkaksakj", Nombre = "Dra. Tung saul", Dias = 69 });
        especialidades.Add(new Especialidades() { Imagen = "pediatria.svg", Especialidad = "Pediatra", Nombre = "Dr. lola lolita", Dias = 68 });
        especialidades.Add(new Especialidades() { Imagen = "traumatologia.svg", Especialidad = "Traumatologia", Nombre = "Dra. Sic Sheve", Dias = 67 });

        return especialidades;
    }

    private void SolicitandoCita(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.Nombre.Text) || string.IsNullOrEmpty(this.Apellidos.Text) || string.IsNullOrEmpty(this.Numero.Text))
        {
            DisplayAlertAsync("Error", "el nombre, apellidos y numero no pueden estar vacios", "ok");
        } else if (string.IsNullOrWhiteSpace(this.Turno.SelectedItem?.ToString()))
        {
            DisplayAlertAsync("Error", "Elige un turno", "ok");
        } else if(this.listaEspecialidades.SelectedItem == null)
        {
            DisplayAlertAsync("Error", "Elige una especialidad", "ok");
        } else if (this.Recuerdame.IsChecked)
        {
            Preferences.Set("Nombre", this.Nombre.Text.Trim());
            Preferences.Set("Apellidos", this.Apellidos.Text.Trim());
            Preferences.Set("Numero", this.Numero.Text);
        }
        else
        {
            Preferences.Remove("Nombre");
            Preferences.Remove("Apellidos");
            Preferences.Remove("Numero");
        }
        Citas cita = new Citas {nombre=this.Nombre.Text, Apellido=this.Apellidos.Text, Turno=this.Turno.SelectedItem.ToString(), Especialidad=(Especialidades)this.listaEspecialidades.SelectedItem, fecha= DateTime.Now};
        path = FileSystem.AppDataDirectory;
        fichero = Path.Combine(path, "citas.json");
        string json = JsonSerializer.Serialize(cita);
        File.AppendAllText(fichero, json);
    }
}