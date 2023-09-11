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

            // creazione lista utenti
            List<User> users = new List<User>();

            // creazione lista documenti
            List<Document> documents = new List<Document>();

            // creazione lista prestiti
            List<Loan> loans = new List<Loan>();

            Library library01 = new Library(documents, users, loans);

            // aggiungo i due utenti istanziati sopra alla lista degli utenti tramite il metodo della classe library
            library01.AddUser(user01);
            library01.AddUser(user02);

            // aggiungo i due libri istanziati sopra alla lista dei documenti tramite il metodo della classe library
            library01.AddDocument(ilVisconteDimezzato);
            library01.AddDocument(cleanCode);

            // aggiungo i due dvd istanziati sopra alla lista dei documenti tramite il metodo della classe library
            library01.AddDocument(interstellar);
            library01.AddDocument(batmanBegins);

            Console.WriteLine("LISTA DEGLI UTENTI REGISTRATI NELLA LIBRERY01:");
            // stampo a schermo le info di tutti gli utenti registrati nella biblioteca library01
            foreach(User user in library01.Users)
            {
                Console.WriteLine(user.Surname);
                Console.WriteLine(user.Name);
                Console.WriteLine(user.Email);
                Console.WriteLine(user.Password);
                Console.WriteLine(user.TelephoneNumber);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("LISTA DOCUMENTI CONTENUTI NELLA LIBRARY01:");
            // stampo a schermo le info di tutti i documenti contenuti nella biblioteca library01
            foreach (Document document in library01.Documents)
            {
                Console.WriteLine(document.IdentificationNumber);
                Console.WriteLine(document.Title);
                Console.WriteLine(document.Year);
                Console.WriteLine(document.Sector);
                Console.WriteLine(document.Shelf);
                Console.WriteLine(document.Author);
                Console.WriteLine("-----------------");
            }




        }
    }
}