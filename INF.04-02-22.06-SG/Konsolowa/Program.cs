Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.count}");
Osoba o1 = new Osoba();
Console.WriteLine("Wprowadź imię dla nowego użytkownika");
string name = Console.ReadLine();
string id;
int newId;
while (true)
{
    Console.WriteLine("Wprowadź id dla nowego użytkownika");
    id = Console.ReadLine();
    if (int.TryParse(id, out int parsedId))
    {
        newId = parsedId;
        break;
    }
    else
    {
        Console.WriteLine("Podano nie poprawne id (podaj tylko liczbę)");
    }
}
Osoba o2 = new Osoba(newId, name);
Osoba o3 = new Osoba(o2);
o1.hello("Jan");
o2.hello("Jan");
o3.hello("Jan");
Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.count}");

internal class Osoba
{
    private int id;
    private string name;
    public static int count = 0;

    public Osoba()
    {
        id = 0;
        name = "";
        count++;
    }
    public Osoba(int id, string name)
    {
        this.id = id;
        this.name = name;
        count++;
    }
    public Osoba(Osoba o)
    {
        this.id = o.id;
        this.name = o.name;
        count++;
    }

    public void hello(string secondName)
    {
        if (name == "")
            Console.WriteLine("Brak Danych");
        else
            Console.WriteLine($"Cześć {secondName}, mam na imię {name}");
    }
}