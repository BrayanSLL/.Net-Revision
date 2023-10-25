namespace TP2Maui.Views;

public partial class ListeNotes : ContentPage
{
	public ListeNotes()
	{
        BindingContext = new Models.CListeNotes();
        InitializeComponent();
        Routing.RegisterRoute($"{nameof(Note)}", typeof(Note));


    }

    private async void Ajouter_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Note));

    }
}