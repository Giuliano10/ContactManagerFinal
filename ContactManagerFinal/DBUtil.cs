using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerFinal
{
    class DBUtil
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;


        public List<Contact> getContactList()
        {
            List<Contact> contactList = new List<Contact>();

            using (var conn = new SqlConnection(connectionString)) {

                SqlCommand scm = new SqlCommand("SELECT * from ContactManager", conn);

                conn.Open();

                using (SqlDataReader sdr = scm.ExecuteReader()) 
                {

                    if (!sdr.HasRows)
                    {

                        Console.WriteLine("Error. No Contacts found.");

                    }
                    else
                    {
                        while (sdr.Read())
                        {

                            Contact c1 = new Contact((int)sdr["IdNumber"], (string)sdr["FirstName"], (string)sdr["LastName"], (string)sdr["PhoneNumber"], (string)sdr["Email"]);

                            contactList.Add(c1);

                        }

                    }
                    
                }
            
            }

            return contactList;

        }




    }
}
