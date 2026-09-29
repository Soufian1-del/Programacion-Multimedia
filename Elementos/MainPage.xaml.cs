namespace Elementos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void Button_Clicked(object sender, EventArgs e)
        {
            String correoEntry = this.correoEntry.Text;
            String comentarioEditor = this.comentarioEditor.Text;
            String cursoPicker = this.cursoPicker.SelectedItem as String;
            
            if (CondicionesCheckbox.IsChecked)
            {
                DisplayAlertAsync("mensaje", "tu email es " + correoEntry, "aceptar");
            } else
            {
                DisplayAlertAsync("mensaje", "resultado: "+ comentarioEditor, "aceptar");
            }
            DisplayAlertAsync("mensaje", "curso: " + cursoPicker, "aceptar");


        }

        private void OnNotificationesToggled(object sender, ToggledEventArgs e)
        {

        }

        private void DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void volumeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }
}
