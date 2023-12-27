using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_03.practice
{
    internal class Program05
    {
        class Address
        {
            string Street { get; set; }
            string City { get; set; }
            string State { get; set; }
            long ZipCode { get; set; }

            public Address( string streeet,string city,string state,long zipCode ) { 
                Street = streeet;
                City = city;
                State = state;
                ZipCode = zipCode;
            }

            public string GetFormattedAddress()
            {
                string s = @$"
Street  : {Street}
City    : {City}
State   : {State}
ZipCode : {ZipCode}
                ";
                return s;
            }

        }
        public static void Main(string[] args)
        {
            Address A = new Address("Buddha Nagar", "Kasola", "Maharashtra", 444403);
            Console.WriteLine(A.GetFormattedAddress());
        }
    }
}
