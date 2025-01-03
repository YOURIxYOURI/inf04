int[] tab = new int[100];
Random rnd = new Random();
for (int i = 0; i < tab.Length; i++)
{
    tab[i] = rnd.Next(0, 1000);
}

sort(tab);

string tmp = "";
for (int i = 0; i < tab.Length; i++)
{
    tmp += $"{tab[i]};";
}
Console.WriteLine($"Posortowana tablica:\n {tmp}");

void sort(int[] tab)
{
    for (int j = 0; j < tab.Length; j++)
    {
        for (int i = 1; i < tab.Length; i++)
        {
            if (tab[i - 1] > tab[i])
            {
                int swap = tab[i - 1];
                tab[i - 1] = tab[i];
                tab[i] = swap;
            }
        }
    }
}

