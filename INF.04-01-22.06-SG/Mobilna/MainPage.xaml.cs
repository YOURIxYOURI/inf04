namespace Mobilna
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            likesLabel.Text = $"{count} polubień";
        }

        private void OnRemoveClicked(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                likesLabel.Text = $"{count} polubień";
            }

        }
    }

}
