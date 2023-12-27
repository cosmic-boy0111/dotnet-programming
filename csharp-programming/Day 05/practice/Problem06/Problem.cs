namespace csharp_programming
{
    internal class Problem
    {
        public abstract class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set;}
            public int Age { get; set; }

            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            public abstract void Greet();
            public abstract void Farewell();
        }

        public class Student : Person
        {
            private string School { get; set; }
            private int GradeLevel { get; set; }
            public Student(
                string firstName, 
                string lastName, 
                int age,
                string school,
                int gradeLevel
                ) 
                : base(firstName, lastName, age)
            {
                this.School = school;
                this.GradeLevel = gradeLevel;
            }

            public override void Farewell()
            {
                Console.WriteLine($"Goodbye, {FirstName}.");
            }

            public override void Greet()
            {
                Console.WriteLine($"Hi, I'm {FirstName} {LastName}, a student at {School}");
            }
        }

        public class Teacher : Person
        {
            private string Subject { get; set; }
            private int YearsTeaching { get; set; }
            public Teacher(
                string firstName, 
                string lastName, 
                int age,
                string subject,
                int yearsTeaching
                ) 
                : base(firstName, lastName, age)
            {
                this.Subject = subject;
                this.YearsTeaching = yearsTeaching;
            }

            public override void Farewell()
            {
                Console.WriteLine($"Have a good day, {FirstName}.");
            }

            public override void Greet()
            {
                Console.WriteLine($"Hello, I'm {FirstName} {LastName}, a teacher of {Subject} for {YearsTeaching} years");
            }
        }

        public static void Main()
        {
            Student s = new Student("Gaurav", "Bhagat", 21, "R.A college", 1);
            s.Greet();
            s.Farewell();
        }
    }
}
