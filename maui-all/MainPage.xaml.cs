using System.Collections.ObjectModel;

namespace maui_all
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Employe> employees = new ObservableCollection<Employe>();
        ObservableCollection<string> jobs = new ObservableCollection<string> { "praca 1", "praca 2", "praca 3" };

        public MainPage()
        {
            InitializeComponent();
            employesList.ItemsSource = employees;
            jobPicker.ItemsSource = jobs;
        }

        private void ageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ageLabel.Text = $"Wiek: {(int)ageSlider.Value}";
        }

        private void Submit_Clicked(object sender, EventArgs e)
        {
            string sex = "";
            if (RadioK.IsChecked)
            {
                sex = "Kobieta";
            }
            else if (RadioM.IsChecked)
            {
                sex = "Mężczyzna";
            }
            employees.Add(new Employe(
                nameEntry.Text.ToString(),
                sex,
                (int)ageSlider.Value,
                jobPicker.SelectedItem.ToString(),
                datePicker.Date.ToString()
            ));
        }

        async private void Details_Clicked(object sender, EventArgs e)
        {
            Employe data = (Employe)employesList.SelectedItem;
            await Shell.Current.GoToAsync($"///Details?data={data.name}", false);
        }
    }
}
