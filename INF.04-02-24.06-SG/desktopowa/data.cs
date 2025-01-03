namespace desktopowa
{
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
