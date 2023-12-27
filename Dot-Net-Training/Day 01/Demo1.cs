using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Training
{
    internal class Demo1
    {
        public static void Main()
        {
            List<Person> people= new List<Person>() { 
                new Person(){ 
                    PersonAge=23, 
                    PersonCity="Delhi", 
                    PersonId = 101,
                    PersonName = "Jojo"
                },
                new Person(){
                    PersonAge=25,
                    PersonCity="Sonipat",
                    PersonId = 102,
                    PersonName = "Popat Lal"
                },
                new Person(){
                    PersonAge=27,
                    PersonCity="Jallandhar",
                    PersonId = 103,
                    PersonName = "Santa Singh"
                },
                new Person(){
                    PersonAge=28,
                    PersonCity="Kanpur",
                    PersonId = 104,
                    PersonName = "Banta Singh"
                },
            };

            var allRecords = from record in people
                             where record.PersonAge >= 25 && record.PersonAge <= 28
                             orderby record.PersonCity
                             select record;
            foreach ( var record in allRecords )
            {
                Console.WriteLine($"Id : {record.PersonId}\tName : {record.PersonName}\tAge : {record.PersonAge}\tCity Name : {record.PersonCity} ");
            }
        }
    }
}
