using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptatiti_dot_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext dcContextObject = new DataClasses1DataContext();

            PratitiEmployee2 empObject = new PratitiEmployee2() { 
                PratitiEmpAge = 23,
                PratitiEmpName= "Jojo",
                PratitiEmpId = 23
            };

            dcContextObject.PratitiEmployee2s.InsertOnSubmit(empObject);
            dcContextObject.SubmitChanges();

            var allRecords = from record in dcContextObject.PratitiEmployee2s
                             select record;

            foreach (var record in allRecords)
            {
                Console.WriteLine($"{record.PratitiEmpId}\t{record.PratitiEmpName}\t{record.PratitiEmpAge}");
            }
        }
    }


    /*
     * So, microsoft decided insted of having so many drivers fotr various
     * databese they created a common orm tool that will take care of connecting 
     * with any databse
     * 
     * this new set of orm tool is referred to entity framework
     * we use ef to connect to databse and table and use the LINQ
     * queries to query our table
     * this flavor is known as LINQ to Entities
     * 
     * Entity Framework gives three different ways to interact with DB:-
     * 1. database first approach
     * 2. model first approach
     * 3. code first approach
     * 
     * code first approach and model first approach, the databse will not 
     * have any table
     * the table(s) will be created through c#.Net.
     * 
     */
}
