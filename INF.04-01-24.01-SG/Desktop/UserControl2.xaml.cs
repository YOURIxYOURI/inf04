using System.Windows;
using System.Windows.Controls;

namespace Desktop
{
    /// <summary>
    /// Logika interakcji dla klasy UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        ContentControl contentControl;
        int albumIndex;
        List<data> albumList;
        public UserControl2(ContentControl contentControl)
        {
            InitializeComponent();
            albumIndex = 0;
            this.contentControl = contentControl;
        }

        void setAlbum(int index)
        {
            artistLabel.Content = albumList[index].artist;
            albumLabel.Content = albumList[index].album;
            songsLabel.Content = albumList[index].songsNumber;
            yearLabel.Content = albumList[index].year;
            downloadLabel.Content = albumList[index].downloadNumber;
        }

        private void GoTo(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = new UserControl1(contentControl);
        }



        //List<data> readFile()
        //{
        //    List<data> list = new();
        //    var lines = File.ReadAllLines("data.txt");
        //    for (int i = 0; i < lines.Length; i += 6)
        //    {
        //        list.Add(new(lines[i], lines[i + 1], int.Parse(lines[i + 2]), int.Parse(lines[i + 3]), int.Parse(lines[i + 4])));
        //    }
        //    return list;
        //}

        private void rigthButton_click(object sender, RoutedEventArgs e)
        {
            if (albumIndex < albumList.Count - 1)
                albumIndex++;
            if (albumIndex >= albumList.Count - 1)
                albumIndex = 0;
            setAlbum(albumIndex);
        }
        private void leftButton_click(object sender, RoutedEventArgs e)
        {
            if (albumIndex == 0)
                albumIndex = albumList.Count - 1;
            if (albumIndex > 0)
                albumIndex--;

            setAlbum(albumIndex);
        }

        private void downloadButton_Click(object sender, RoutedEventArgs e)
        {
            albumList[albumIndex].downloadNumber++;
            setAlbum(albumIndex);
        }
    }
    internal class data
    {
        public string artist { get; set; }
        public string album { get; set; }
        public int songsNumber { get; set; }
        public int year { get; set; }
        public int downloadNumber { get; set; }

        public data() { }
        public data(string artist, string album, int songsNumber, int year, int downloadNumber)
        {
            this.artist = artist;
            this.album = album;
            this.songsNumber = songsNumber;
            this.year = year;
            this.downloadNumber = downloadNumber;
        }

        public override string ToString()
        {
            return $"{artist}\n{album}\n{songsNumber}\n{year}\n{downloadNumber}\n";
        }
    }
}
