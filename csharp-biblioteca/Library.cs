using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Library
    {
        public List<Document> Documents { get; set; }

        // utilizzo del dizionario
        //public Dictionary<string, Document> Documents { get; set; }
        public List<User> Users { get; internal set; }
        public List<Loan> Loans { get; internal set; }

        public Library(List<Document> documents, List<User> users, List<Loan> loans)
        {
            this.Documents = documents;
            this.Users = users;
            this.Loans = loans;
        }

        // METODI

        // metodo per l'aggiunta del documento
        public void AddDocument(Document document)
        {
            Documents.Add(document);
        }

        // metodo per l'aggiunta del'utente
        public void AddUser(User user)
        {
            Users.Add(user);
        }

        // metodo per l'aggiunta del prestito
        public void AddLoan(Loan loan)
        {
            Loans.Add(loan);
        }

        // metodo per la ricerca di un documento per titolo || per codice
        public List<Document> SearchDocument(string searchKey)
        {
            // lamba function
            return Documents.Where(doc => doc.Title.Contains(searchKey) || doc.IdentificationNumber.Contains(searchKey)).ToList();
        }

        // metodo per la ricerca del prestito per utente (nome && cognome)
        public List<Loan> SearchLoanByUserNameOrUserSurname(string name, string surname)
        {
            return Loans.Where(loan => loan.UserName == name && loan.UserSurname == surname).ToList();
        }

        // metodo per registrare un prestito
        public void RegisterLoan (User user, Document document, DateTime endDate)
        {
            // controllo che l'utente sia contenuto nella lista degli utenti
            if(!Users.Contains(user))
            {
                Console.WriteLine("Utente non registrato");

                return;
            }

            // controllo che il documento sia contenuto nella lista dei documenti della libreria
            if(!Documents.Contains(document))
            {
                Console.WriteLine("Documento non disponibile per il noleggio");

                return;
            }

            // controllo che la data di fine prestito non sia pari o superiore a quella di inizio prestito
            foreach (var item in Loans)
            {
                if(item.Document == document && item.EndDate >= item.StartDate)
                {
                    Console.WriteLine("Documento attualmente in prestito");

                    return;
                }
            }

            Loan loan = new Loan(user.Name, user.Surname, document, endDate);

            Loans.Add(loan);

            Console.WriteLine("Prestito registrato con successo");
        }
    }
}
