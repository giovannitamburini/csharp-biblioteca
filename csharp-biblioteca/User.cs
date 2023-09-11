using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TelephoneNumber { get; set; }

        // COSTRUTTORE

        public User(string surname, string name, string email, string password, string telephoneNumber)
        {
            this.Surname = surname;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.TelephoneNumber = telephoneNumber;
        } 

    }
}
