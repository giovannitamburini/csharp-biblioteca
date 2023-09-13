using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    {
        public string IdentificationNumber { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Sector { get; set; }
        public string Shelf { get; set; }
        public string Author { get; set; }


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

        public override string ToString()
        {
            return $"Document{this.IdentificationNumber}:\n" +
                $"\t-Title: {this.Title}\n" +
                $"\t-Year: {this.Year}\n" +
                $"\t-Author: {this.Author}\n";
        }
    }
}
