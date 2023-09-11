namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
            Si vuole progettare un sistema per la gestione di una biblioteca.
            Gli utenti si possono registrare al sistema, fornendo:
            - cognome
            - nome
            - email
            - password
            - recapito telefonico

            Gli utenti registrati possono prendere in prestito dei documenti che sono di vario tipo (libri, DVD).
            I documenti sono caratterizzati da:
            - un codice identificativo di tipo stringa
            - titolo
            - anno
            - settore (storia, matematica, economia, …)
            - uno scaffale in cui è posizionato
            - un autore (Nome, Cognome)

            Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

            L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, prendere in prestito registrando il periodo (Dal/Al) del prestito e il documento.

            Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

            Creiamo anche una classe Biblioteca che contiene la lista dei documenti, la lista degli utenti e la lista dei prestiti.

            Contiene inoltre i metodi per le ricerche e per l’aggiunta dei documenti, utenti e prestiti.
            */

            // SVOLGIMENTO ESERCIZIO -----------------------------------------------------------------

            // istanzio un nuovo utente
            User user01 = new User("Tamburini", "Giovanni", "giovanni@mail.it", "password", "339 4583029");
            User user02 = new User("Bianchi", "Giulia", "giulia@mail.it", "password1", "339 1234529");

            // istanzio un nuovo libro della sottoclasse Book
            Book ilVisconteDimezzato = new Book("027947478", "Il Visconte Dimezzato", 1952, "letteratura", "A05", "Italo Calvino", 144);
            Book cleanCode = new Book("0132350882", "Clean Code", 2008, "programmazione", "G11", "Robert C. Martin", 431);

            // istanzio un nuovo dvd della sottoclasse Dvd
            Dvd interstellar = new Dvd("03496484", "Interstellar", 2014, "fantascienza", "C09", "Christopher Nolan", 169);
            Dvd batmanBegins = new Dvd("03986583", "Batman Begins", 2005, "azione, fantastico", "C25", "Christopher Nolan", 140);

            // creazione array utenti
            List<User> users = new List<User>();
            // aggiungo gli utenti, creati precedentemente, alla lista "users"
            users.Add(user01);
            users.Add(user02);

            // creazione array libri
            List<Book> books = new List<Book>();
            // aggiungo i libri, creati precedentemente, alla lista "books"
            books.Add(ilVisconteDimezzato);
            books.Add(cleanCode);

            // creazione array dvd
            List<Dvd> dvds = new List<Dvd>();
            // aggiungo i dvd, creati precedentemente, alla lista "dvds"
            dvds.Add(interstellar);
            dvds.Add(batmanBegins);
        }
    }
}