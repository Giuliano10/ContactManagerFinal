using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerFinal
{
    class Contact
    {
        public Contact( string name, string phoneNumber, string email)
        {

            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;

        }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }





    }
}

