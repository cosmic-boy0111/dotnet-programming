using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace csharp_programming
{
    class Program
    {
        private static DbProviderFactory _providerFactory = SqlClientFactory.Instance;
        public static void Main(string[] args)
        {
            try
            {
                string connectingString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
                IDbConnection connection = _providerFactory.CreateConnection();
                connection.ConnectionString = connectingString;
                connection.Open();

                IDbCommand authorCommand = connection.CreateCommand();
                authorCommand.CommandType = CommandType.Text;
                authorCommand.CommandText = @"SELECT Au_ID, Author From Authors 
                                              WHERE Au_ID >= @from AND Au_ID < @to";

                DbParameter fromParam = _providerFactory.CreateParameter();
                fromParam.ParameterName = "@from";
                fromParam.Value = 1;

                DbParameter toParam = _providerFactory.CreateParameter();
                toParam.ParameterName = "@to";
                toParam.Value = 10;

                authorCommand.Parameters.Add(fromParam);
                authorCommand.Parameters.Add(toParam);

                IDataReader authorReader = authorCommand.ExecuteReader();

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