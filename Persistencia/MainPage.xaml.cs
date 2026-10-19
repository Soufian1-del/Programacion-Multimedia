namespace Persistencia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       
        private void preferenciaButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Preferencia());
        }

        private void baseButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.BaseDatos());

        }

        private void ficheroButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Fichero());
        }
    }
}
