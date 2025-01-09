using System.Windows;
using System.Windows.Controls;

namespace wpf_all
{
    /// <summary>
    /// Logika interakcji dla klasy DetailsPage.xaml
    /// </summary>
    public partial class DetailsPage : UserControl
    {
        ContentControl contentControl;
        Employe employe;
        Window window;
        public DetailsPage(ContentControl contentControl, Window window, Employe employe)
        {
            InitializeComponent();
            this.contentControl = contentControl;
            this.employe = employe;
            this.window = window;
            window.Title = "Details, title set from C#";
            nameLabel.Content = employe.name;
            sexLabel.Content = employe.sex;
            ageLabel.Content = employe.age;
            joinDateLabel.Content = employe.joinDate;
            jobLabel.Content = employe.job;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new MainPage(contentControl, window);
        }
    }
}
