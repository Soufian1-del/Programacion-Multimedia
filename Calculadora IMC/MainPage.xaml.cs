using Microsoft.Maui.Graphics.Text;

namespace Calculadora_IMC
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void CalculoDeIMC(object sender, EventArgs e)
        {
            String peso = this.peso.Text;
            String altura = this.altura.Text;
            int PesoInt = Int32.Parse(peso);
            int AlturaInt = Int32.Parse(altura);
            if (AlturaInt == 0 || PesoInt == 0)
            {
                await DisplayAlertAsync("error", "debe de ser numeros mayores a 0", "ok");
            } else
            {
                int imc = PesoInt/(AlturaInt * AlturaInt);
                String imcText = imc.ToString();
                await DisplayAlertAsync("mensaje", imcText, "mensaje");

            }
        }
    }
}
