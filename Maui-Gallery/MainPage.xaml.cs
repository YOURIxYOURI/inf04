namespace Maui_Gallery
{
    public partial class MainPage : ContentPage
    {
        int middleIndex = 1;
        int leftIndex = 0;
        int rightIndex = 2;
        List<string> imagesUri = new List<string> { "obraz1.png", "obraz2.png", "obraz3.png", "obraz4.png" };
        public MainPage()
        {
            InitializeComponent();
        }

        private void left_Button_Clicked(object sender, EventArgs e)
        {
            middleIndex--;
            if (middleIndex < 0)
                middleIndex = imagesUri.Count - 1;
            leftIndex--;
            if (leftIndex < 0)
                leftIndex = imagesUri.Count - 1;
            rightIndex--;
            if (rightIndex < 0)
                rightIndex = imagesUri.Count - 1;

            leftImage.Source = imagesUri[leftIndex];
            middleImage.Source = imagesUri[middleIndex];
            RigthImage.Source = imagesUri[rightIndex];
        }

        private void rigth_Button_Clicked(object sender, EventArgs e)
        {
            middleIndex++;
            if (middleIndex > imagesUri.Count - 1)
                middleIndex = 0;
            leftIndex++;
            if (leftIndex > imagesUri.Count - 1)
                leftIndex = 0;
            rightIndex++;
            if (rightIndex > imagesUri.Count - 1)
                rightIndex = 0;

            leftImage.Source = imagesUri[leftIndex];
            middleImage.Source = imagesUri[middleIndex];
            RigthImage.Source = imagesUri[rightIndex];
        }

        private void BackgroundSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            var _sender = (Switch)sender;
            if (_sender.IsToggled)
                appGrid.BackgroundColor = Colors.Aqua;
            else
                appGrid.BackgroundColor = Colors.ForestGreen;
        }
    }

}
