namespace Konsola
{
    /*
     ******************************
     Klasa: Notatka
     Opis: Klasa reprzentuje prostą instancje notatki razem z jej identyfikatorem ustawianym z pomocą zmienej statycznej służącą jako inkrementacja id 
     Pola: count - zmienna statyczna któa służy do inkrementacji ID
            id - unikalny identyfikator klasy zależny od ilośći stworzonych instancji
            title - tytuł notatki 
            content - zawartość notatki/treść notatki
    autor: 00000000000
     ******************************
     
     
     */
    internal class Notatka
    {
        private static int count = 0;
        private int id;
        protected string title;
        protected string content;


        public Notatka(string title, string content)
        {
            count++;
            this.id = count;
            this.title = title;
            this.content = content;
        }

        public void readNote()
        {
            Console.WriteLine($"Tytuł: {title}\n {content}");
        }
        public void noteInfo()
        {
            Console.WriteLine($"{count};{id};{title};{content}");
        }
    }
}
