using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class NewPage10 : ContentPage
{
    ObservableCollection<string> Kolory = new ObservableCollection<string> { };
	public NewPage10()
	{
		InitializeComponent();
	}

    private void PobierzButton_Clicked(object sender, EventArgs e)
    {
        int cyfra_R = (int)Slider_R.Value;
        int cyfra_G = (int)Slider_G.Value;
        int cyfra_B = (int)Slider_B.Value;

        DrugiKolor_Rectangle.Fill = new SolidColorBrush(Color.FromRgb((byte)cyfra_R, (byte)cyfra_G, (byte)cyfra_B));
        Kolory.Add("#" + cyfra_R.ToString("X2") + cyfra_G.ToString("X2") + cyfra_B.ToString("X2"));
        Label_Lista_Kolorów.Text = string.Join(", ", Kolory);
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int cyfra_R = (int)Slider_R.Value;
        int cyfra_G = (int)Slider_G.Value;
        int cyfra_B = (int)Slider_B.Value;

        Label_R.Text = cyfra_R.ToString();
        Label_G.Text = cyfra_G.ToString();
        Label_B.Text = cyfra_B.ToString();

        Kolor_Rectangle.Fill = new SolidColorBrush(Color.FromRgb((byte)cyfra_R, (byte)cyfra_G, (byte)cyfra_B));


        string R = cyfra_R.ToString("X2");
        string G = cyfra_G.ToString("X2");
        string B = cyfra_B.ToString("X2");

        Kolor_Label.Text = "#" + R + G + B;
    }
}