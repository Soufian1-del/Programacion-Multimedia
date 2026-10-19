namespace Login
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            this.Nombre.Text = Preferences.Get("Nombre", String.Empty);
            this.contraseña.Text = Preferences.Get("contraseña", String.Empty);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (this.Recuerdame.IsChecked)
            {
                Preferences.Set("Nombre", this.Nombre.Text);
                Preferences.Set("contraseña", this.contraseña.Text);
            }
            else
            {
                Preferences.Remove("Nombre");
                Preferences.Remove("contraseña");
            }
        }
    }
}
