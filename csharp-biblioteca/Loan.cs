using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Loan
    {
        //public User UserName { get; set; }
        //public User UserSurname { get; set; }
        //public Document Document { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }

        //public Loan(User userName, User userSurname, Document document, DateTime endDate)
        //{
        //    this.UserName = userName;
        //    this.UserSurname = userSurname;
        //    this.Document = document;
        //    this.StartDate = DateTime.Today;
        //    this.EndDate = endDate;
        //}

        // principio della composizione
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public Document Document { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Loan(string userName, string userSurname, Document document, DateTime endDate)
        {
            this.UserName = userName;
            this.UserSurname = userSurname;
            this.Document = document;
            this.StartDate = DateTime.Today;
            this.EndDate = endDate;
        }
    }
}