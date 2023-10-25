using System.Text;

namespace MauiApp1.Views;

public partial class vEcran : ContentPage
{
	public vEcran()
	{
		InitializeComponent();
		ScreenInfo();

    }

	private void ScreenInfo()
	{
		System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.AppendLine($"Résolution:{DeviceDisplay.Current.MainDisplayInfo.Width}X{DeviceDisplay.Current.MainDisplayInfo.Height}");
		sb.AppendLine($"Densité:{DeviceDisplay.Current.MainDisplayInfo.Density}");
		sb.AppendLine($"Orientation:{DeviceDisplay.Current.MainDisplayInfo.Orientation}");
        sb.AppendLine($"RefreshRate:{DeviceDisplay.Current.MainDisplayInfo.RefreshRate}");
        lbScreenInfo.Text = sb.ToString();

    }
}