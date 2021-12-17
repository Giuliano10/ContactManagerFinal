using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerFinal
{
    class Contact
    {

        public Contact() { } //no arg

        public Contact( int idNumber, string firstName, string lastName, string phoneNumber, string email) //full constructor with record unique identifier (IdNumber)
        {
            this.IdNumber = idNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;

        }

        public Contact(string firstName, string lastName, string phoneNumber, string email) //constructor for new contact (id numbers are auto-incremented)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;


        }
        
        //getters & setters
        public int IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }





    }
}

