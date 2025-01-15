using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace wpf_all
{
    /// <summary>
    /// Logika interakcji dla klasy MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        ObservableCollection<string> jobsList = new ObservableCollection<string> { "Job 1", "Job 2", "Job 3" };

        Window window;
        ContentControl contentControl;
        Employe employe { get; set; } = new Employe();
        public MainPage(ContentControl contentControl, Window window)
        {
            InitializeComponent();
            this.contentControl = contentControl;
            jobComboBox.ItemsSource = jobsList;
            window.Title = "Home set from C#";
            this.window = window;
            jobListView.ItemsSource = jobsList;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            imageToChange.Source = new BitmapImage(new Uri("/obraz.jpg", UriKind.Relative));
        }

        private void Slider_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            Slider _sender = (Slider)sender;
            ageLabel.Content = $"Age: {(int)_sender.Value}";
        }

        private async void GoToDetails(object sender, System.Windows.RoutedEventArgs e)
        {
            string sexString = "";
            if (maleRadio.IsChecked == true)
                sexString = "Male";
            else if (femaleRadio.IsChecked == true)
                sexString = "Female";

            MessageBox.Show($"{nameEntry.Text.ToString()} {(int)ageSlider.Value}", "Info", MessageBoxButton.OK);

            employe = new Employe(nameEntry.Text.ToString(), (int)ageSlider.Value, jobComboBox.SelectedItem.ToString(), datePicker.SelectedDate.ToString(), sexString);

            contentControl.Content = new DetailsPage(contentControl, window, employe);

        }
    }
}
