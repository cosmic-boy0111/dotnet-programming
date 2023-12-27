
namespace csharp_programming
{
    class FileException : Exception
    {
        public int Caouse { get; set;  }

        public const int FileNotFoundException = 1;
        public const int BadPath = 2;
        public const int DiskFull = 3;

        private static string GetMessage(int cause)
        {
            string message = null;
            switch (cause)
            {
                case FileNotFoundException:
                    message = "File Not Fount";
                    break;
                case BadPath:
                    message = "Invalid Path";
                    break;
                case DiskFull:
                    message = "Disk is Full";
                    break;
                default:
                    message = "File error";
                    break;
            }

            return message;
        }

        public FileException(int cause) : base(GetMessage(cause))
        {
            this.Caouse = cause;
        }

    }
    class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                if (!File.Exists("example.txt"))
                    throw new FileException(FileException.FileNotFoundException);
                if (!Directory.Exists("X:\\temp"))
                    throw new FileException(FileException.BadPath);
            }catch(FileException e) when (e.Caouse == FileException.FileNotFoundException)
            {
                File.Create("example.txt");
            }catch (FileException e) when (e.Caouse == FileException.BadPath)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}

/*
 * Exception filters was introduced in C# 6.0.
 * It adds additional conditions on the catch block. 
 * The condition must evaluate to true for the catch
 * block to handle the exception.
 */