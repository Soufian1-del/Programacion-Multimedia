using Collection;
using System.Text.Json;

namespace Citas.Pages;

public partial class consultar : ContentPage
{    string rutaCitas = Path.Combine(FileSystem.AppDataDirectory, "citas.json");

	public consultar()
	{
		InitializeComponent();
        this.ListaCitas.ItemsSource = CargarCitas();

    }



    private List<Citas> CargarCitas()
	{
        string json = File.ReadAllText(rutaCitas);
        List<Citas> citas = JsonSerializer.Deserialize<List<Citas>>(json);

		return citas;
	}
}