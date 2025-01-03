namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        List<string> list = new List<string> { "Pies", "Kot", "Świnka morska" };
        public MainPage()
        {
            InitializeComponent();
            petsList.ItemsSource = list;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }
    }

}
