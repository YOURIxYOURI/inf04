while (true)
{
    Console.WriteLine("Podaj pierwszą liczbe wprowadzaną do algorytmu euklidesa");
    string inputA = Console.ReadLine();
    if (int.TryParse(inputA, out int a) && a > 0)
    {
        while (true)
        {
            Console.WriteLine("Podaj drugą liczbe wprowadzaną do algorytmu euklidesa");
            string inputB = Console.ReadLine();
            if (int.TryParse(inputB, out int b) && b > 0)
            {
                Console.WriteLine($"NWD dla liczb {a}, {b} wynosi: {NWD(a, b)}");
                break;
            }
            else
            {
                Console.WriteLine("Podano nieprawidłowy format liczby");
                continue;
            }
        }
    }
    else
    {
        Console.WriteLine("Podano nieprawidłowy format liczby");
        continue;
    }
    break;
}

/*
************************************************* 
nazwa funkcji: NWD
opis funkcji: funkcja stosuje algorytm euklidesa w celu znalezienia NWD
parametry: a - pierwsza liczba dodatnia całkowita do algorytmu
           b - druga liczba dodatnia całkowita do algorytmu
zwracany typ i opis: int (liczba całkowita), liczba reprezentująca największy wspólny dzielnik
autor: 00000000000
************************************************* 
 */

int NWD(int a, int b)
{
    while (true)
    {
        if (a != b)
            if (a > b)
                a = a - b;
            else
                b = b - a;
        else
            return a;
    }
}