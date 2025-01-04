using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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