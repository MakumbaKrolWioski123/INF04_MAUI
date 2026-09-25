namespace MauiApp1;

public partial class NewPage4 : ContentPage
{
	public NewPage4()
	{
		InitializeComponent();
        PickerDaty.MinimumDate = DateTime.Now;
	}

    private void Osoby_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		string wartosc = Osoby.Value.ToString("F0");
		Label_Osoby.Text = "Liczba osób: " + wartosc;
    }

    private void Rezerwacja_Clicked(object sender, EventArgs e)
    {
        string wartosc = Osoby.Value.ToString("F0");
        string sala = "";
        if (Sale.SelectedItem==null)
        {
            DisplayAlert("Alert", $"Nie wybrano sali", "OK");
        }
        else
        {
           sala = Sale.SelectedItem.ToString();


            if (Sale.SelectedIndex==-1)
            {
                DisplayAlert("Alert", $"Nie wybrano sali", "OK");
            }
            else
            {
                DisplayAlert("Informacje", $"Ilosc osob: {wartosc}\n" +
                $"Sala: {sala}\n" +
                $"Data: {PickerDaty.Date:yyyy-MM-dd}", "OK");
            }
        }
        

       
       

    }
}