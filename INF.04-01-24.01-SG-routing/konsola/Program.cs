string pesel = "55030101193";
List<int> wages = new List<int> { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

char checkSex(string pesel)
{
    if (pesel[9] % 2 == 0)
        return 'K';
    else
        return 'M';
}

bool peselValidation(string pesel)
{
    int controlSum = 0;
    for (int i = 0; i < pesel.Length - 1; i++)
    {
        controlSum += int.Parse(pesel[i].ToString()) * wages[i];
    }
    int m;
    if (controlSum % 10 == 0)
    {
        m = 0;
    }
    else
    {
        m = 10 - (controlSum % 10);
    }
    if (m == pesel[10])
        return true;
    return false;

}

Console.WriteLine("Podaj nr PESEL do sprawdzenia");
pesel = Console.ReadLine();

Console.WriteLine($"Płęć ustalona na podstawie nr PESEL to {checkSex(pesel)}");

if (peselValidation(pesel))
    Console.WriteLine($"Podany nr PESEL jest prawdiłowy");
else
    Console.WriteLine($"Podany nr PESEL jest nieprawidłowy");
