using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace csharp_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string connectingString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
                DbConnection connection = new SqlConnection(connectingString);
                connection.Open();

                DbCommand authorCommand = connection.CreateCommand();
                authorCommand.CommandType = CommandType.Text;
                authorCommand.CommandText = "SELECT Au_ID, Author From Authors WHERE Au_ID < 20";

                DbDataReader authorReader = authorCommand.ExecuteReader();

                while (authorReader.Read())
                {
                    Console.WriteLine("{0}\t:\t{1}", authorReader["Au_ID"], authorReader["Author"]);
                }

                authorReader.Close();
                connection.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}