using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_databse_first_approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PratitiEmployee2 empItem = new PratitiEmployee2() { 
                PratitiEmpAge = 26,
                PratitiEmpName = "Popat Bhaiya",
                PratitiEmpId= 28,
            };

            PratitiDBEntities entityObject = new PratitiDBEntities();
            entityObject.PratitiEmployee2.Add(empItem);
            entityObject.SaveChanges();

            var allRecords = from record in entityObject.PratitiEmployee2
                             select record;

            foreach (var record in allRecords)
            {
                Console.WriteLine($"{record.PratitiEmpId}\t{record.PratitiEmpName}\t{record.PratitiEmpAge}");
            }

        }
    }
}

/*
 * POCO :- playing old clr object
 * with working ORM :- must create a table with primary key
 * work with EF database first approach
 * steps:
 *      1. Add a reference of entity framework by opting
 *         for "Manage NUGet" packages.
 * 
 */
