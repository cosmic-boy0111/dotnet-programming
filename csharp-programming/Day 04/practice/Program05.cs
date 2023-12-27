namespace csharp_programming
{
    internal class Program05
    {
        public class Logger
        {
            public delegate void LogMessage(string message);

            public void Log(string message, LogMessage MessageFunction)
            {
                MessageFunction(message);
            }
        }

        public static void ConsoleLogger(string message)
        {
            Console.WriteLine(message);
        }

        public static void FileLogger(string message)
        {
            Console.WriteLine(message);
        }

        public static void Main()
        {
            Logger l = new Logger();
            l.Log("Console is open", ConsoleLogger);
            l.Log("File is open", FileLogger);
        }

    }
}
