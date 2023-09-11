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
        public List<Document> AddDocument(Document document)
        {
            Documents.Add(document);

            return Documents;
        }

        // metodo per l'aggiunta del'utente
        public List<User> AddUser(User user)
        {
            Users.Add(user);

            return Users;
        }

        // metodo per la ricerca di un documento per titolo

        // metodo per la ricerca di un documento per codice
        

        //public List<Loan> AddLoan(User userName, User userSurname, Document document, DateTime endDate)
        //{
        //    
        //}
    }
}
