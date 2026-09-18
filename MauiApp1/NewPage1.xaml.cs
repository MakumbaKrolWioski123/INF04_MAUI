namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Pokaż_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(Imie_Entry.Text)&& !string.IsNullOrEmpty(Miasto_Entry.Text))
		{
            string imie = Imie_Entry.Text;
            string miasto = Miasto_Entry.Text;
            Powitanie.Text = $"Witaj {imie} z miasta {miasto}.";
        }
        else
        {
            Powitanie.Text = "Wypełnij oba pola!";
        }


		
    }
}