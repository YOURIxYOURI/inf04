using Konsola;

//utworzenie obiektów testowych

Notatka test1 = new Notatka("Tytuł1", "To jest treść pierwszej notatki");
Notatka test2 = new Notatka("Tytuł2", "To jest treść drugiej notatki, któa jest inna niż pierwsza");

//wywołanie metod w celu testu

test1.readNote();
test2.readNote();

Console.WriteLine("\nInformacje diagnostyczne\n");

test1.noteInfo();
test2.noteInfo();