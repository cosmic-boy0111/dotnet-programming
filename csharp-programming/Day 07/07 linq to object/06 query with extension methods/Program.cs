namespace csharp_programming {
    class Person {
        public string Name { get; set; }
        public int YearBorn { get; set; }
    }

    class Program {
        static void Main(string[] args) {
            Person[] Persons = new Person[10];
            Persons[0] = new Person { Name = "Jacobb, Rusell", YearBorn = 1992 };
            Persons[1] = new Person { Name = "Metzger, Philip W.", YearBorn = 1983 };
            Persons[2] = new Person { Name = "Boddie, John", YearBorn = 1975 };
            Persons[3] = new Person { Name = "Sydow, Dan Parks", YearBorn = 1975 };
            Persons[4] = new Person { Name = "Gaylord, Richard", YearBorn = 1976 };
            Persons[5] = new Person { Name = "Thiel, James R.", YearBorn = 1999 };
            Persons[6] = new Person { Name = "Ingham, Kenneth", YearBorn = 2001 };
            Persons[7] = new Person { Name = "Wellin, Paul", YearBorn = 1980 };
            Persons[8] = new Person { Name = "Kamin, Sam", YearBorn = 1960 };
            Persons[9] = new Person { Name = "Gaylord, Richard", YearBorn = 1976 };

            // query with extension methods
            var queryResults = (from person in Persons select person.Name).Distinct();
            foreach (string item in queryResults) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Person firstPerson = (from person in Persons select person).First<Person>();
            Console.WriteLine(firstPerson.Name + " " + firstPerson.YearBorn);

            Console.WriteLine();

            Person lastPerson = (from person in Persons select person).Last<Person>();
            Console.WriteLine(lastPerson.Name + " " + lastPerson.YearBorn);

            Console.WriteLine();

            int count = (from person in Persons select person).Count();
            Console.WriteLine("Count={0}", count);

            Console.WriteLine();

            var w = (from person in Persons select person).Where(a => a.YearBorn > 1980);
            foreach (Person a in w) {
                Console.WriteLine(a.Name + " " + a.YearBorn);
            }
        }
    }
}
