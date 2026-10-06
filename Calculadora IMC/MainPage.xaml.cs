using Microsoft.Maui.Graphics.Text;

namespace Calculadora_IMC
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private void CalculoDeIMC(object sender, EventArgs e)
        {
            String peso = this.peso.Text;
            String altura = this.altura.Text;
            try
            {
                        double PesoInt = double.Parse(peso);
                        double AlturaInt = double.Parse(altura);
                        if (AlturaInt == 0 || PesoInt == 0)
                        {
                             DisplayAlertAsync("error", "debe de ser numeros mayores a 0", "ok");
                        } else
                        {                            
                            double imc = Math.Round(PesoInt / (AlturaInt * AlturaInt), 2);

                    switch (imc)
                    {
                        case < 18.5:
                            this.LabelResultado.Text = "Tu imc es: " + imc;
                            this.ImageResultado.Source = "delgado.png";
                                break;
                        case >18.5 and <24.9:
                            this.LabelResultado.Text = "Tu imc es: " + imc;
                            this.ImageResultado.Source = "normal.png";
                            break;
                                case >25 and <29.9 :
                            this.LabelResultado.Text = "Tu imc es: " + imc;
                            this.ImageResultado.Source = "sobrepeso.png";
                            break;
                                case > 30:
                            this.LabelResultado.Text = "Tu imc es: " + imc;
                            this.ImageResultado.Source = "obeso.png";
                            break;
                    }
                        }
            }
            catch (FormatException)
            {
                DisplayAlertAsync("bla", "bla", "bla", "bla");
            }
            
        }
    }
}
