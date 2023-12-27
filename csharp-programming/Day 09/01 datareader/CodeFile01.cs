using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace csharp_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string connectingString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectingString);
                connection.Open();

                SqlCommand authorCommand = connection.CreateCommand();
                authorCommand.CommandType = CommandType.StoredProcedure;
                authorCommand.CommandText = "AuthorDetails";
                SqlParameter authorId = new SqlParameter("@au_id",1);
                authorCommand.Parameters.Add(authorId);

                SqlDataReader authorReader = authorCommand.ExecuteReader();

                if (authorReader.HasRows)
                {
                    authorReader.Read();
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