using System.Windows;

namespace wpf_all
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            contentControl.Content = new MainPage(contentControl, this);

        }
    }
}