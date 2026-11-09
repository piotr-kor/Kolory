namespace Kolory
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Suwak_ValueChanged(object sender, EventArgs e)
        {
            int r = (int)SuwakR.Value;
            int g = (int)SuwakG.Value;
            int b = (int)SuwakB.Value;

            WartoscR.Text = r.ToString();
            WartoscG.Text = g.ToString();
            WartoscB.Text = b.ToString();

            DuzyProstokat.BackgroundColor =
                Color.FromRgb(r, g, b);     //Color to wbudowana w .NET MAUI klasa
        }

        private void Pobierz_Clicked(object sender, EventArgs e)
        {
            int r = (int)SuwakR.Value;
            int g = (int)SuwakG.Value;
            int b = (int)SuwakB.Value;

            MalyProstokat.BackgroundColor =
                Color.FromRgb(r, g, b);

            Wynik.Text = $"RGB: {r}, {g}, {b}";
        }
    }
}
