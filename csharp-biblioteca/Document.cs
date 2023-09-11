using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    {
        public string IdentificationNumber { get; }
        public string Title { get; }
        public int Year { get; }
        public string Sector { get; }
        public string Shelf { get; set; }
        public string Author { get; }


        // COSTRUTTORE
        public Document(string identificationNumber, string title, int year, string sector, string shelf, string author)
        {
            this.IdentificationNumber = identificationNumber;
            this.Title = title;
            this.Year = year;
            this.Sector = sector;
            this.Shelf = shelf;
            this.Author = author;
        }

    }
}
