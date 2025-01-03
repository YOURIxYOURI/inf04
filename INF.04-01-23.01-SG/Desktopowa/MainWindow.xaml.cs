using System.Windows;

namespace Desktopowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string lowerLetters = "qwertyuiopasdfghjklzxcvbnm";
        string upperLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
        string numbers = "1234567890";
        string specialSigns = "!@#$%^&*()_+-=";
        string Password = "";
        string[] comboBoxOptions = { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" };
        public MainWindow()
        {
            InitializeComponent();
            PositionBox.ItemsSource = comboBoxOptions;
        }

        private void Confirm_Creating_Employee_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Dane pracownika: {firstNameBox.Text.ToString()} {lastNameBox.Text.ToString()} {PositionBox.Text.ToString()} Hasło: {Password}");
        }
        private void Generate_Password_Click(object sender, RoutedEventArgs e)
        {
            Password = "";
            Random rnd = new Random();
            if (int.TryParse(PasswordLengthBox.Text.ToString(), out int passLength))
            {
                if (UpperLettersBox.IsChecked == true && Password.Length < passLength)
                {
                    Password += upperLetters[rnd.Next(0, upperLetters.Length)];
                }
                if (NumbersBox.IsChecked == true && Password.Length < passLength)
                {
                    Password += numbers[rnd.Next(0, numbers.Length)];
                }
                if (SignsBox.IsChecked == true && Password.Length < passLength)
                {
                    Password += specialSigns[rnd.Next(0, specialSigns.Length)];
                }
                while (passLength > Password.Length)
                {
                    Password += lowerLetters[rnd.Next(0, lowerLetters.Length)];
                }
                MessageBox.Show($"{Password}");
            }
            else
            {
                MessageBox.Show($"Nie prawidłowy format w polu: 'ilę znaków?'");
            }
        }
    }
}