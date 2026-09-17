namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Przycisk_Powitanie_Clicked(object sender, EventArgs e)
        {
            count++;
            Etykieta_Powitania.Text = "Dziekujemy za uruchomienie aplikacji.";
            Licznik.Text = $"Licznik kliknieć: {count}";
        }

        private void Przycisk_Reset_Clicked_1(object sender, EventArgs e)
        {
            count++;
            Etykieta_Powitania.Text = "Witamy w aplikacji!";
            Licznik.Text = $"Licznik kliknieć: {count}";
        }


    }
}
