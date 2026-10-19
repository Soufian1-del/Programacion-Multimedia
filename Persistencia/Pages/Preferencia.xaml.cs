namespace Persistencia.Pages;

public partial class Preferencia : ContentPage
{
	public Preferencia()
	{
		InitializeComponent();
		
		this.userName.Text = Preferences.Get("usuario", String.Empty);
		this.password.Text = Preferences.Get("password", String.Empty);

    }

    private void guardarButton_Clicked(object sender, EventArgs e)
    {
		if (this.recordarCheckBox.IsChecked)
		{
			Preferences.Set("usuario", this.userName.Text.Trim());
			Preferences.Set("password", this.password.Text.Trim());
		}
        else
        {
			// Se borra lo que estaba guardado (si es q habia algo) y no guarda nada
			Preferences.Remove("usuario");
			Preferences.Remove("password");
        }
    }
}