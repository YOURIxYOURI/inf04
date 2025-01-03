using System.IO;
using System.Windows;

namespace desktopowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int albumIndex;
        List<data> albumList;
        public MainWindow()
        {
            InitializeComponent();
            albumIndex = 0;
            albumList = readFile();
            setAlbum(albumIndex);
        }

        void setAlbum(int index)
        {
            artistLabel.Content = albumList[index].artist;
            albumLabel.Content = albumList[index].album;
            songsLabel.Content = albumList[index].songsNumber;
            yearLabel.Content = albumList[index].year;
            downloadLabel.Content = albumList[index].downloadNumber;
        }



        List<data> readFile()
        {
            List<data> list = new();
            var lines = File.ReadAllLines("data.txt");
            for (int i = 0; i < lines.Length; i += 6)
            {
                list.Add(new(lines[i], lines[i + 1], int.Parse(lines[i + 2]), int.Parse(lines[i + 3]), int.Parse(lines[i + 4])));
            }
            return list;
        }

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

}