namespace csharp_programming
{
    internal class Problem
    {
        public static void Main()
        {
            AndroidPhone a = new AndroidPhone("Oppo", "Oppo f21 pro 5G", 15.5, "13", 4);
            a.Call();
            a.Text();

            iPhone i = new iPhone("iPhone","iPhone 15",14,"i7",true);
            i.Call();
            i.Text();
        }
    }
}
