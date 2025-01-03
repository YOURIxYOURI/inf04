Film test = new Film();
Console.WriteLine($"{test.title}, liczba wypożyczeń:{test.rentCount}");
test.title = "tytuł filmu";
test.Rent();
Console.WriteLine($"{test.title}, liczba wypożyczeń:{test.rentCount}");



/*
 *****************************************************************
    nazwa klasy: Film
    pola: _title - ciąg znakowy reprezentujący tytuł filmu
          _rentCount - liczbę całkowitą reprezentującą liczbe wyporzyczeń filmu
    metody: Rent, brak wartosci zwracanej(void) - metoda inkrementująca pole _rentCount
    informacje: klasa reprezentuje cześć systemu wypożyczania filmów, zaimplementowany jest licznik wypożyczeń,
    autor: 00000000000
 *****************************************************************
 */
internal class Film
{
    protected string _title;
    protected int _rentCount;
    public string title { get { return _title; } set { _title = value; } }
    public int rentCount { get { return _rentCount; } }
    public Film()
    {
        _title = "";
        _rentCount = 0;
    }

    public void Rent()
    {
        _rentCount++;
    }
}