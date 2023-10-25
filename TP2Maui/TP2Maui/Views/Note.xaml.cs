namespace TP2Maui.Views;

public partial class Note : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, $"{Path.GetRandomFileName()}.notes.txt");

    public Note()
	{
		InitializeComponent();
        if (File.Exists(_fileName))
            TextEditor.Text = File.ReadAllText(_fileName);

    }

    private async void ButtonEnregistrer_Clicked(object sender, EventArgs e)
    {

        if (BindingContext is Models.CNote note)
            File.WriteAllText(note.Filename, TextEditor.Text);
        await Shell.Current.GoToAsync("..");


    }

    private void ButtonSupprimer_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
            File.Delete(_fileName);
        TextEditor.Text = string.Empty;
    }
}