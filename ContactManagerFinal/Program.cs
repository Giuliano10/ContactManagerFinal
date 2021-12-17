using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerFinal
{
    class Program
    {

            static void Main(string[] args)
            {

                Part1A();

                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine();
                Part1B();
                Console.ReadKey();
            }

            static void Part1A()
            {
                DBUtil db = new DBUtil();


                Console.WriteLine("Totaly Quantity of sales: " + db.TotalSales());

                Console.WriteLine();

                Console.WriteLine("Average  Quantity of sales: " + db.SalesAverage());

            }

            static void Part1B()
            {
            DBUtil db = new DBUtil();

                db.getContactList();

            }
        }
    }


















}
}
