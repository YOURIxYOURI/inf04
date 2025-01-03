int[] tab = new int[51];

void fullfill(int[] tab)
{
    Random random = new Random();
    for (int i = 0; i < tab.Length - 1; i++)
    {
        tab[i] = random.Next(1, 101);
    }
}

// nazwa funkcji: search
// argumenty: tab - przekazana tablica na której funkcja operuje
// typ zwracany: int, zwracany jest index na którym została znaleziona wartość szukana lub indeks wartownika
// informacje: funkcja prosi uzytkownika o podanie szukanej wartośći(wartownika) i używa algorytmu przeszukującego z użyciem wartownika
// autor: 00000000000

int search(int[] tab)
{
    int searchedValue;
    while (true)
    {
        Console.WriteLine("Podaj wartość do wyszukania");
        string x = Console.ReadLine();
        if (int.TryParse(x, out searchedValue))
        {
            break;
        }
        else
        {
            Console.WriteLine("Podano zły format liczby");
        }
    }
    tab[tab.Length - 1] = searchedValue;


    for (int i = 0; i < tab.Length; i++)
    {
        if (tab[i] == searchedValue)
            return i;
    }
    return -1;
}

fullfill(tab);
int index = search(tab);
string tmp = "";
for (int i = 0; i < tab.Length - 1; i++)
    tmp += $"{tab[i]}, ";

Console.WriteLine(tmp);
if (index == tab.Length - 1)
{
    Console.WriteLine("Nie znaleziono elementu");
}
else
{
    Console.WriteLine($"znaleziono wartość pod indexem: {index}");
}

