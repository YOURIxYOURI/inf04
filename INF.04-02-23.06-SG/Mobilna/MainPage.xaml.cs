namespace Mobilna
{
    public partial class MainPage : ContentPage
    {
        int index = 0;
        string[] tab = { "Dzień dobry", "Good morning", "Buenos dias" };
        public MainPage()
        {
            InitializeComponent();
            welcomeLabel.Text = tab[index];
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            if (index < 2)
                index++;
            else
                index = 0;

            welcomeLabel.Text = tab[index];
        }

        private void Slider_change(object sender, EventArgs e)
        {
            Slider slider = (Slider)sender;

            sizeLabel.Text = $"Rozmiar: {(int)slider.Value}";
            welcomeLabel.FontSize = (int)slider.Value;
        }
    }

}
