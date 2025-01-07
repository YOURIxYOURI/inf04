using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Desktop
{
    /// <summary>
    /// Logika interakcji dla klasy UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        ContentControl contentControl;
        public UserControl1(ContentControl contentControl)
        {
            InitializeComponent();
            this.contentControl = contentControl;
        }

        private void GoTo2(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = new UserControl2(contentControl);
        }
        private void numberEntry_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                var entry = (TextBox)sender;

                string url = $@"/{entry.Text.ToString()}-zdjecie.jpg";

                personImage.Source = new BitmapImage(new Uri(url, UriKind.Relative));

                url = $@"/{entry.Text.ToString()}-odcisk.jpg";

                printImage.Source = new BitmapImage(new Uri(url, UriKind.Relative));
            }
            catch (Exception ex) { }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(firstNameEntry.Text.ToString()) && !string.IsNullOrEmpty(lastNameEntry.Text.ToString()))
            {
                string eyes = "";
                if (greenCheckbox.IsChecked == true)
                    eyes = "zielone";
                else if (blueCheckbox.IsChecked == true)
                    eyes = "niebieskie";
                else if (beerCheckbox.IsChecked == true)
                    eyes = "piwne";
                MessageBox.Show($"{firstNameEntry.Text.ToString()} {lastNameEntry.Text.ToString()} kolor oczu {eyes}");
            }
            else
            {
                MessageBox.Show("Wprowadź dane");
            }
        }
    }
}
