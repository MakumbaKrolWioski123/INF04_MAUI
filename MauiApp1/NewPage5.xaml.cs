namespace MauiApp1;

public partial class NewPage5 : ContentPage
{
	public NewPage5()
	{
		InitializeComponent();
	}

    private void Plus_Clicked(object sender, EventArgs e)
    {
        int liczba = int.Parse(Liczba_Label.Text)+1;
        Liczba_Label.Text = $"{liczba}";
    }

    private void Minus_Clicked(object sender, EventArgs e)
    {
        int liczba = int.Parse(Liczba_Label.Text)-1;
        if(int.Parse(Liczba_Label.Text)>0)
        {
            Liczba_Label.Text = $"{liczba}";
        }
       
       
    }

    private void Zeruj_Clicked(object sender, EventArgs e)
    {
        Liczba_Label.Text = "0";
    }
}