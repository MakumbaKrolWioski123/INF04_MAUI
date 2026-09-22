namespace MauiApp1;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}

    private void Zapisz_Clicked(object sender, EventArgs e)
    {
		string imie = Imie.Text;
		string nazwisko = Nazwisko.Text;
		bool wiedza = Wiedza.IsChecked;
		bool certyfikat = Certyfikat.IsToggled;
        object kurs = RadioButtonGroup.GetSelectedValue(Kursy1);
		string oczekiwania = Oczekiwania.Text;
        string wiedza1 = "";
		string certyfikat1 = "";

		if (wiedza)
		{ wiedza1 = "Tak"; }
		else { wiedza1 = "Nie"; }

        if (certyfikat)
        { certyfikat1 = "Tak"; }
        else { certyfikat1 = "Nie"; }



        if (!string.IsNullOrWhiteSpace(imie)&&!string.IsNullOrWhiteSpace(nazwisko))
		{
			DisplayAlert("Informacje:",
				$"Imie: {imie}, " +
				$"Nazwisko: {nazwisko}\n" +
				$"Posiadam podstawową wiedzę: {wiedza1}\n" +
				$"Chce otrzymać certyfikat: {certyfikat1}\n" +
				$"Wybrany kurs: {kurs}\n"+
				$"Oto twoje oczekiwania: {oczekiwania}", "OK");
		}
		else
		{
			DisplayAlert("Alert!", "Podaj imie i nazwisko!", "OK");
		}
    }
}