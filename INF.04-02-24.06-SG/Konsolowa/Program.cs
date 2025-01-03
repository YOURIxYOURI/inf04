

List<data> albumsList = readFile();

writeAllData(albumsList);



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

/*
 ***********************************************************************************
    nazwa funkcji: writeAllData
    opis funkcji: funkcja wypisująca wszytkie wartości przekazanej kolekcji(listy)
    parametry: list - lista obiektów data(albumów)
    zwracany typ i opis: brak
    autor: 00000000000

 ***********************************************************************************
 
 */

void writeAllData(List<data> list)
{
    foreach (var data in list)
        Console.WriteLine(data.ToString());
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




