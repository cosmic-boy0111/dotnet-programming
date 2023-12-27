namespace csharp_programming {
    class Person {
        public string Name { get; set; }
        public int YearBorn { get; set; }
    }
    class Program {
        static void Main() {
            Person[] persons = new Person[10];
            persons[0] = new Person { Name = "Jacobb, Rusell", YearBorn = 1992 };
            persons[1] = new Person { Name = "Metzger, Philip W.", YearBorn = 1983 };
            persons[2] = new Person { Name = "Boddie, John", YearBorn = 1975 };
            persons[3] = new Person { Name = "Sydow, Dan Parks", YearBorn = 1975 };
            persons[4] = new Person { Name = "Lloyd, John", YearBorn = 1976 };
            persons[5] = new Person { Name = "Thiel, James R.", YearBorn = 1999 };
            persons[6] = new Person { Name = "Ingham, Kenneth", YearBorn = 2001 };
            persons[7] = new Person { Name = "Wellin, Paul", YearBorn = 1980 };
            persons[8] = new Person { Name = "Kamin, Sam", YearBorn = 1960 };
            persons[9] = new Person { Name = "Gaylord, Richard", YearBorn = 1976 };

            // simple query
            var queryResults = from person in persons select person;

            foreach (Person item in queryResults) {
                Console.WriteLine(item.Name + " " + item.YearBorn);
            }
        }
    }
}

/*
 * LINQ (Language-Integrated Query) is a feature of C# that allows you to query
 * data from various data sources, including arrays, collections, databases,
 * and XML files. The general syntax of a LINQ query in C# is as follows:
 * 
 * var query = from variable in source
 *          [where condition]
 *          [orderby key]
 *          [select projection];
 *
 * variable: This is a new variable that is created to represent each element
 * of the source collection. You can use any name for the variable.
 * 
 * source: This is the data source that you want to query. It can be an array,
 * a collection, a database table, or any other data source that implements
 * the IEnumerable<T> interface.
 * 
 * where condition: This is an optional clause that filters the data based on
 * a specified condition. The condition can be any Boolean expression that
 * evaluates to true or false.
 * 
 * orderby key: This is an optional clause that sorts the data based on a
 * specified key. You can use the ascending or descending keyword to sort
 * the data in ascending or descending order.
 * 
 * select projection: This is an optional clause that projects the data into
 * a new form. You can select any properties of the source elements or create
 * new properties based on the existing properties.
 * 
 * The result of a LINQ query is an IEnumerable<T> object that contains the
 * elements that match the specified criteria. You can iterate over the result
 * using a foreach loop, or convert it to a list or an array using the ToList()
 * or ToArray() extension methods.
 */ 