namespace MauiApp1;

public partial class NewPage7 : ContentPage
{
	public NewPage7()
	{
		InitializeComponent();
	}

	void ObliczButton_Clicked(System.Object sender, System.EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(szerkokoscEntry.Text) || !string.IsNullOrWhiteSpace(wysokoscEntry.Text))
        {
            if(double.TryParse(szerkokoscEntry.Text, out double szerokosc) && double.TryParse(wysokoscEntry.Text, out double wysokosc))
            {
                double a = szerokosc;
                double b = wysokosc;
                wynikLabel.Text = $"Pole wynosi: {a * b}";
            }
        }
    }

    void WyczyśćButton_Clicked(System.Object sender, System.EventArgs e)
    { 
        DisplayActionSheet("Czy chcesz wyczyścić pola?", "Anuluj", null, "Tak", "Nie").ContinueWith(wybor =>
        {
            if (wybor.Result == "Tak")
            {
                szerkokoscEntry.Text = string.Empty;
                wysokoscEntry.Text = string.Empty;
                wynikLabel.Text = string.Empty;
            }
        }, TaskScheduler.FromCurrentSynchronizationContext());
    }
}