namespace maui_routing
{
    [QueryProperty(nameof(_pm), "name")]
    public partial class MainPage : ContentPage
    {
        string pm;
        public string _pm { set { pm = value; OnPropertyChanged(); label.Text = value; } }
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"///NewPage1?name={"to jest parametr z main page"}");
        }
    }

}
