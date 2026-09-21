namespace MauiApp1;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

    private void Zamowienie_Clicked(object sender, EventArgs e)
    {
		string produkt = Produkt.Text;
		string ilosc = Ilosc.Text;
		string adres = Adres.Text;
		if(!string.IsNullOrWhiteSpace(produkt) && !string.IsNullOrWhiteSpace(ilosc) && !string.IsNullOrWhiteSpace(adres))
		{
			DisplayAlert("Udało sie!",$"Produkt: {produkt}\nIlosc: {ilosc}\nAdres dostawy: {adres}","OK");
		}
		else
		{
			DisplayAlert("Nie udało sie!", "Uzupełnij wszystkie pola", "OK");
		}
    }
}