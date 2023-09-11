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
        public List<Document> SearchDocument(string chiaveRicerca)
        {
            return Documents.Where(doc => doc.Title.Contains(chiaveRicerca) || doc.IdentificationNumber.Contains(chiaveRicerca)).ToList();
        }

        // metodo per la ricerca del prestito per utente (nome && cognome)
        public List<Loan> SearchLoanByUserNameOrUserSurname(string name, string surname)
        {
            return Loans.Where(loan => loan.UserName == name && loan.UserSurname == surname).ToList();
        }

        //public void RegisterLoan
    }
}
