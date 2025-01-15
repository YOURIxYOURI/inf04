namespace maui_all;


[QueryProperty(nameof(Data), "data")]
public partial class Details : ContentPage
{
    string data;
    public string Data { get => data; set { data = value; nameLabel.Text = value; OnPropertyChanged(); } }
    public Details()
    {
        InitializeComponent();
    }

    async private void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}