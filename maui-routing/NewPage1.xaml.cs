namespace maui_routing;

[QueryProperty(nameof(_pm), "name")]
public partial class NewPage1 : ContentPage
{
    public string _pm { set { label.Text = value; } }
    public NewPage1()
    {
        InitializeComponent();
    }
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///MainPage?name={"to jest parametr"}");
    }
}