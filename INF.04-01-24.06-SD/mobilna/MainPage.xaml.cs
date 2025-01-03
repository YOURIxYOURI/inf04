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



        private void ageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ageLabel.Text = $"Ile ma lat? {(int)ageSlider.Value}";
        }

        private void petsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedValue = e.SelectedItem as string;
            if (selectedValue == "Pies")
                ageSlider.Maximum = 18;
            if (selectedValue == "Kot")
                ageSlider.Maximum = 20;
            if (selectedValue == "Świnka morska")
                ageSlider.Maximum = 9;
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Zapisana wizyta", $"{ownerEntry.Text}, {petsList.SelectedItem}, {goalEntry.Text}, {(int)ageSlider.Value}, {timeEntry.Time}", "OK");
        }
    }

}
