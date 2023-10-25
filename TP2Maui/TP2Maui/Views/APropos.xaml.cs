namespace TP2Maui.Views;

public partial class APropos : ContentPage
{
	public APropos()
	{
		InitializeComponent();
	}

    private async void APropos_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.CApropos apropos)
        {
            await Launcher.Default.OpenAsync(apropos.MoreInfoUrl);
        }

    }
}