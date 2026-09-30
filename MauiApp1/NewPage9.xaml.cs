namespace MauiApp1;

public partial class NewPage9 : ContentPage
{
	public NewPage9()
	{
		InitializeComponent();
	}

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
        int cyfra_R = (int)Slider_Koloru.Value;
        int cyfra_G = (int)Slider_Koloru.Value;
        int cyfra_B = (int)Slider_Koloru.Value;

        string R = cyfra_R.ToString("X2");
        string G = cyfra_G.ToString("X2");
        string B = cyfra_B.ToString("X2");

        suwakLabel.Text = "#" + R + G + B;
    }

	private void zmienKolorButton_Clicked(object sender, EventArgs e)
    {
        int cyfra_R = (int)Slider_Koloru.Value;
        int cyfra_G = (int)Slider_Koloru.Value;
        int cyfra_B = (int)Slider_Koloru.Value;

        Strona.BackgroundColor = Color.FromRgb(cyfra_R, cyfra_G, cyfra_B);
    }
}