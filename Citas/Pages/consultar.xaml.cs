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
        if (!File.Exists(rutaCitas))
            return new List<Citas>();
        string json = File.ReadAllText(rutaCitas);
        if (string.IsNullOrWhiteSpace(json))
            return new List<Citas>();
        return JsonSerializer.Deserialize<List<Citas>>(json) ?? new List<Citas>();
    }
}