using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        public string Duration { get; }

        public Dvd(string identificationNumber, string title, string year, string sector, string shelf, string author, string duration) : base(identificationNumber, title, year, sector, shelf, author)
        {
            this.Duration = duration;
        }
    }
}
