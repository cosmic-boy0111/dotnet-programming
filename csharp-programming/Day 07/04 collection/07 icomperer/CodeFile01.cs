namespace csharp_programming
{
    
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {

            List<Person> list = new List<Person>() { 
                new Person() { Name = "Gopal" ,  Age = 25},
                new Person() { Name = "Vikram" ,  Age = 30},
                new Person() { Name = "Shweta" ,  Age = 20},
            };

            list.Sort(new PersonComparer());

            foreach (Person x in list)
            {
                Console.WriteLine($"{x.Name} : {x.Age}");
            }



        }
    }
}
