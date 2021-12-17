using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerFinal
{
    class DBUtil
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;


        public List<Contact> GetContactList()
        {
            List<Contact> contactList = new List<Contact>();

            using (var conn = new SqlConnection(connectionString))
            {

                SqlCommand scm = new SqlCommand("SELECT * from Contacts", conn);

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

        public Contact GetContact(int IdNumber)
        {

            Contact cslct = null;

            using (var conn = new SqlConnection(connectionString))
            {

                SqlCommand scm = new SqlCommand("SELECT * from Contacts WHERE IdNumber= @IdNumber", conn);
                scm.Parameters.AddWithValue("@IdNumber", IdNumber);
                conn.Open();

                using (SqlDataReader sdr = scm.ExecuteReader())
                {

                    if (!sdr.HasRows)
                    {

                        Console.WriteLine("Error. No Contacts found.");

                    }
                    else
                    {
                        sdr.Read();

                        cslct = new Contact((int)sdr["IdNumber"], (string)sdr["FirstName"], (string)sdr["LastName"], (string)sdr["PhoneNumber"], (string)sdr["Email"]);

                    }

                }

            }
            return cslct;
        }


        public int AddContact(Contact theContact)
        {

            int newId = 0;

            SqlConnection conn = new SqlConnection(connectionString);

            string queryStmt = "INSERT INTO Contacts ( FirstName, LastName, PhoneNumber, Email ) values ( @FirstName, @LastName, @PhoneNumber, @Email )";

            SqlCommand scm = new SqlCommand(queryStmt, conn);


            scm.Parameters.AddWithValue("@FirstName ", theContact.FirstName);
            scm.Parameters.AddWithValue("@LastName ", theContact.LastName);
            scm.Parameters.AddWithValue("@PhoneNumber ", theContact.PhoneNumber);
            scm.Parameters.AddWithValue("@Email ", theContact.Email);


            try
            {

                conn.Open();

                var rowsAffected = scm.ExecuteNonQuery();
                Console.WriteLine("Contact created.");

                string queryStmt2 = "SELECT @@Identity as newId from Contacts";
                scm.CommandText = queryStmt2;
                scm.CommandType = CommandType.Text;
                scm.Connection = conn;

                newId = Convert.ToInt32(scm.ExecuteScalar());

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: " + e.ToString());

            }
            finally { conn.Close(); }

            return newId;

        }


        public void UpdateContact(Contact theContact)
        {


            SqlConnection conn = new SqlConnection(connectionString);
            string queryStmt = "UPDATE Contacts set FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Email = @Email where IdNumber = @IdNumber ";

            SqlCommand scm = new SqlCommand(queryStmt, conn);


            scm.Parameters.AddWithValue("@IdNumber ", theContact.IdNumber);
            scm.Parameters.AddWithValue("@FirstName ", theContact.FirstName);
            scm.Parameters.AddWithValue("@LastName ", theContact.LastName);
            scm.Parameters.AddWithValue("@PhoneNumber ", theContact.PhoneNumber);
            scm.Parameters.AddWithValue("@Email ", theContact.Email);


            try
            {
                conn.Open();

                var rowsAffected = scm.ExecuteNonQuery();
                Console.WriteLine("Contact updated.");
                Console.WriteLine();
                //Console.WriteLine(theContact);

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: " + e.ToString());

            }
            finally { conn.Close(); }

        }

        public void DeleteContact(Contact theContact)
        {

            SqlConnection conn = new SqlConnection(connectionString);

            string queryStmt = "DELETE from Contacts where IdNumber = @IdNumber";

            SqlCommand scm = new SqlCommand(queryStmt, conn);

            scm.Parameters.AddWithValue("@IdNumber", theContact.IdNumber);


            try
            {
                conn.Open();

                var rowsAffected = scm.ExecuteNonQuery();
                Console.WriteLine("Contact deleted.");

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: " + e.ToString());

            }
            finally { conn.Close(); }



        }






    }



}