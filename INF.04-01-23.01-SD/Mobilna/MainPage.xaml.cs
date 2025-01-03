using System.Collections.ObjectModel;

namespace Mobilna
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> notes = new ObservableCollection<string>
        {
            "Zakupy: chleb, masło, ser",
            "Do zrobienia: obiad, umyć podłogi",
            "weekend: kino, spacer z psem"
        };
        public MainPage()
        {
            InitializeComponent();
            NoteListView.ItemsSource = notes;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NoteEntry.Text.ToString()))
                notes.Add(NoteEntry.Text.ToString());
        }
    }

}
