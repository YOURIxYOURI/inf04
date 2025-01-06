namespace maui_routing;

[QueryProperty(nameof(_pm), "name")]
public partial class NewPage1 : ContentPage
{
    string pm;
    public string _pm { set { pm = value; OnPropertyChanged(); label.Text = value; } }
    public NewPage1()
    {
        InitializeComponent();
    }
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///MainPage?name={"to jest parametr"}");
    }
}