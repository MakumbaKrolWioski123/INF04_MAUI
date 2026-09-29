using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class NewPage8 : ContentPage
{
    ObservableCollection<string> zakupy = new ObservableCollection<string> { };
    public NewPage8()
	{
		InitializeComponent();
    }

    public void dodajButton_Clicked(object sender, EventArgs e)
    {
        if(!string.IsNullOrWhiteSpace(daneEntry.Text))
        {
            zakupy.Add("- "+daneEntry.Text);
            daneEntry.Text = string.Empty;
            listaLabel.Text = string.Join(Environment.NewLine,zakupy);
        }
    }
}