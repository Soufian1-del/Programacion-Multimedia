namespace Layout
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void Vertical_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.VerticalPage());
        }

        private void Horizontal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.HorizontalPage());

        }

        private void grid_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.GridPage());

        }

        private void absolute_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.AbsolutePage());

        }

        private void flex_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.FlexPage());

        }
    }
}
