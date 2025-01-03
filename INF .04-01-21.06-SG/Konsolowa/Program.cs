
program test = new program();

Console.WriteLine($"Najwiękasza wartość tablicy: {test.findMax()}");
test.sort();

public class program
{
    public int[] tab { get; set; } = new int[10];

    public program()
    {
        Console.WriteLine("Wypełnij tablice liczbami całkowytymi ");
        for (int i = 0; i < 10; i++)
        {
            while (true)
            {
                var str = Console.ReadLine();
                if (int.TryParse(str, out int number))
                {
                    tab[i] = number;
                    break;
                }
                else
                {
                    Console.WriteLine("wpisano liczbe w złym formacie, podaj kolejny raz");
                }
            }
        }
    }
    public program(int[] tab)
    {
        this.tab = tab;
    }


    /*
     
     * nazwa funkcji: sort
     * paremetry wejściowe: brak
     * wartość zwracana: void - brak wartosći zwracanej
     * autor: 00000000000
     
        funkcja sortuje tablice z pomocą algorytmyu wybierania 
        
     */
    public void sort()
    {
        for (int i = 0; i < 10; i++)
        {
            int indexToSwap = 0;
            int min = int.MaxValue;
            for (int j = i; j < 10; j++)
            {
                if (tab[j] < min)
                {
                    min = tab[j];
                    indexToSwap = j;
                }
            }
            int swap = tab[i];
            tab[i] = tab[indexToSwap];
            tab[indexToSwap] = swap;
        }
        Console.WriteLine("Posortowana tablica");
        for (int i = 0; i < 10; i++)
            Console.WriteLine($"{tab[i]} ");
    }

    /*

 * nazwa funkcji: findMax
 * paremetry wejściowe: brak
 * wartość zwracana: int - wartosć maksymalna tablicy
 * autor: 00000000000

    funckja przeszukuje tablice w znalezieniu maksymalne wartośći

 */
    public int findMax()
    {
        int max = tab[0];
        for (int i = 1; i < tab.Length; i++)
        {
            if (tab[i] > max)
            {
                max = tab[i];
            }
        }
        return max;
    }
}