namespace maui_all;


[QueryProperty(nameof(Data), "data")]
public partial class Details : ContentPage
{
    public string Data { get { return Data; } set { Data = value; } } // nie dzia�a chuj wie dlaczego (jest identyczne do dzia�aj�cego  zinnego rozwi�zania)
    public Details()
    {
        InitializeComponent();
        nameLabel.Text = Data;
    }

    async private void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}