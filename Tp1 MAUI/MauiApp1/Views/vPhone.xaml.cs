namespace MauiApp1.Views;

public partial class vPhone : ContentPage
{
	public vPhone()
	{
		InitializeComponent();
        Routing.RegisterRoute($"{nameof(vEcran)}", typeof(vEcran));
        PhoneInfo();

    }

	private void PhoneInfo()
	{
        System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
		stringBuilder.AppendLine($"Modèle:{DeviceInfo.Current.Model}");
        stringBuilder.AppendLine($"Manufactureur:{DeviceInfo.Current.Manufacturer}");
        stringBuilder.AppendLine($"Version:{DeviceInfo.VersionString}");
		stringBuilder.AppendLine($"Version:{DeviceInfo.Name}");
        stringBuilder.AppendLine($"Plateforme:{DeviceInfo.Current.Platform}");
        stringBuilder.AppendLine($"Idiom:{GetIdiom()}");
        lbPhoneInfo.Text = stringBuilder.ToString();

    }

	private string GetIdiom()
	{
        if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone)
        {
            return "TV";
        }else if (DeviceInfo.Current.Idiom == DeviceIdiom.Tablet)
        {
            return "Tablette";
        }
        else if (DeviceInfo.Current.Idiom == DeviceIdiom.Desktop)
        {
            return "PC";
        }else
        {
            return "Inconnu";
        }
        
    }

    private async void Ecran_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(vEcran));

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(vBatterie));
    }
}