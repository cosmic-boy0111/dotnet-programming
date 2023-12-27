namespace csharp_programming
{
    internal class Program10
    {
        public class DateTimeExtensions
        {
            public static string ToShortDate(DateTime date)
            {
                string s = date.ToString().Split(' ')[0];
                string[] split_dash = s.Split('-');
                return split_dash[0] + '/' + split_dash[1] + '/' + split_dash[2];
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(DateTimeExtensions.ToShortDate(new DateTime(2023, 12, 10)));
        }
    }
}
