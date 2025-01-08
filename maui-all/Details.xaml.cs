namespace maui_all;


[QueryProperty(nameof(Data), "data")]
public partial class Details : ContentPage
{
    public string Data { get { return Data; } set { Data = value; } } // nie dzia³a chuj wie dlaczego (jest identyczne do dzia³aj¹cego  zinnego rozwi¹zania)
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