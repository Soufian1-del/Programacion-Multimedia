using Android.Text;

namespace Collection
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            this.listaPaises.ItemsSource= cargarPaises();
        }

        private List<Pais> cargarPaises()
        {
            List<Pais> paises = new List<Pais>();

            paises.Add(new Pais() { nombre = "España", bandera = "https://flagcdn.com/64x48/es.png", capital = "Madrid" });
            paises.Add(new Pais() { nombre = "Japon", bandera = "https://flagcdn.com/64x48/jp.png", capital = "Tokyo" });
            paises.Add(new Pais() { nombre = "Nepal", bandera = "https://flagcdn.com/64x48/np.png", capital = "Kathmandu" });
            paises.Add(new Pais() { nombre = "Romania", bandera = "https://flagcdn.com/64x48/ro.png", capital = "Bucarest" });
            paises.Add(new Pais() { nombre = "Norfolk Island", bandera = "https://flagcdn.com/64x48/nf.png", capital = "Kingston" });

            return paises;
            }

        private async void listaPaises_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pais pais = (Pais)e.CurrentSelection[0];
            // DisplayAlertAsync("mensaje", "has seleccionado " + pais.nombre , "aceptar");
            String respuesta = await DisplayPromptAsync("indica la capital", "Capital: " + pais.nombre, "ok", "cancelar");

            if(respuesta != null)
            {
                 if (String.Equals(pais.capital, respuesta, StringComparison.CurrentCultureIgnoreCase))
                            {
                                DisplayAlertAsync("Correcto", "has escrito " + respuesta, "aceptar");

                            }
                            else 
                            {
                                DisplayAlertAsync("Incorrecto", "has escrito " + respuesta, "aceptar");

                            }
            }
           
        }
    }
}
