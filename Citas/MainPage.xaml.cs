namespace Citas
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Solicitar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.solicitar());
        }

        private void Consultar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.consultar());

        }
    }
}
