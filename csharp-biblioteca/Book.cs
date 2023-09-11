using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Book : Document
    {
        public int PagesNumber { get; }

        public Book (string identificationNumber, string title, string year, string sector, string shelf, string author, int pagesNumber) : base(identificationNumber, title, year, sector, shelf, author)
        {
            this.PagesNumber = pagesNumber;
        }
    }
}
