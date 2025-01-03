
Console.WriteLine("Proszę podać tekst do sprawdzenia");
string toCheck = Console.ReadLine();

Console.WriteLine($"Liczba samogłosekw  podannym tekście wynosi: {StringTools.countVowel(toCheck)}");
Console.WriteLine($"Tekst po usunieciu duplikatów wygląda nasetepująco:\n{StringTools.reapetDelete(toCheck)}");



/*
 *************************************************************************************************
    klasa: StrinTools
    opis: klasa zawiera narzędzia(metody) operujące na zmiennej typu string 
    metody: countVowel - metoda zwraca liczbę całkowitą reprezentujacą liczbe samogłosek w sprawdzanym tekście
            reapetDelete - metoda zwraca ciąg znaków po usunieciu duplikujących sie znaków w sprawdzanmym tekście
    autor: 00000000000
 *************************************************************************************************
 */

internal class StringTools
{
    public static int countVowel(string toCheck)
    {
        if (!string.IsNullOrEmpty(toCheck))
        {
            List<char> vowelList = new List<char> { 'a', 'ą', 'e', 'E', 'i', 'o', 'u', 'ó', 'y' };
            toCheck = toCheck.ToLower();
            int counter = 0;
            for (int i = 0; i < toCheck.Length; i++)
            {
                foreach (var vowel in vowelList)
                {
                    if (toCheck[i] == vowel)
                    {
                        counter++;
                        break;
                    }
                }
            }
            return counter;
        }
        return 0;
    }

    public static string reapetDelete(string toCheck)
    {
        if (!string.IsNullOrEmpty(toCheck))
        {
            string tmp = "" + toCheck[0];
            for (int i = 1; i < toCheck.Length; i++)
            {
                if (toCheck[i - 1] == toCheck[i])
                    continue;
                else
                    tmp += toCheck[i];
            }
            return tmp;
        }
        return "";
    }
}

