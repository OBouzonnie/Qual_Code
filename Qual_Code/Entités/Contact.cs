using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_Code.Entités
{
    internal class Contact:BaseEntity
    {
        public string Firstname { get; set; }
        
        public string Lastname { get; set; }
        
        public string Email { get; set; }
        
        public string Phone { get; set; }

        public Contact(string firstname, string lastname, string email, string phone)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
            this.Phone = phone;
        }
    }
}
