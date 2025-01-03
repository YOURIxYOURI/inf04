namespace Mobilna
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(Object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text) || string.IsNullOrEmpty(confirmEntry.Text))
            {
                infoOutput.Text = "Jendo z pól jest puste";
            }
            else
            {

                bool check = false;
                for (int i = 0; emailEntry.Text.Length > i; i++)
                {
                    if (emailEntry.Text[i] == '@')
                        check = true;
                }
                if (check && passwordEntry.Text == confirmEntry.Text)
                {
                    infoOutput.Text = $"Witaj {emailEntry.Text}";
                }
                else if (!check)
                {
                    infoOutput.Text = $"Nieprawidłowy adres email";
                }
                else if (passwordEntry.Text != confirmEntry.Text)
                {
                    infoOutput.Text = $"Hasła się różnią";
                }
            }
        }
    }

}
