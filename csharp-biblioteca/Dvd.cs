using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        // ATTRIBUTI, PROPRIETA', STATI
        public int DurationInMinutes { get; }

        public Dvd(string identificationNumber, string title, int year, string sector, string shelf, string author, int durationInMinutes) : base(identificationNumber, title, year, sector, shelf, author)
        {
            this.DurationInMinutes = durationInMinutes;
        }
    }
}
