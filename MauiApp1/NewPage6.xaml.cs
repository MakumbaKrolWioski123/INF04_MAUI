namespace MauiApp1;

public partial class NewPage6 : ContentPage
{
	public NewPage6()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int cyfra_R = (int)Slider_R.Value;
        int cyfra_G = (int)Slider_G.Value;
        int cyfra_B = (int)Slider_B.Value;

        Label_R.Text = $"R: {cyfra_R}";
        Label_G.Text = $"G: {cyfra_G}";
        Label_B.Text = $"B: {cyfra_B}";

        string R = cyfra_R.ToString("X2");
        string G = cyfra_G.ToString("X2");
        string B = cyfra_B.ToString("X2");

        Kolor_Label.Text = "#"+R+G+B;

        Kolor_Label.BackgroundColor = Color.FromRgb(cyfra_R, cyfra_G, cyfra_B);
    }
}