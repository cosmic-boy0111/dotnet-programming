using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System;

namespace csharp_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string connectingString = ConfigurationManager.ConnectionStrings["PratitiDB"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectingString);
                connection.Open();

                SqlCommand authorsCommand = connection.CreateCommand();
                authorsCommand.CommandType = CommandType.Text;
                authorsCommand.CommandText = "SELECT PratitiEmpId, PratitiEmpName, PratitiEmpAge FROM PratitiEmployee2";

                DataSet employeeDataSet = new DataSet();
                SqlDataAdapter authorsAdapter = new SqlDataAdapter(authorsCommand);
                authorsAdapter.Fill(employeeDataSet, "Employees");

                SqlCommandBuilder authorCommandBuilder = new SqlCommandBuilder(authorsAdapter);

                DataRow empRow = employeeDataSet.Tables["Employees"].NewRow();

                Random random= new Random();

                empRow["PratitiEmpId"] = random.Next(1,1000);
                empRow["PratitiEmpName"] = "Gaurav Bhagat";
                empRow["PratitiEmpAge"] = 21;
                employeeDataSet.Tables["Employees"].Rows.Add(empRow);


                foreach (DataRow theRow in employeeDataSet.Tables["Employees"].Rows)
                {
                    Console.WriteLine(theRow["PratitiEmpId"] + "\t" + theRow["PratitiEmpName"]);
                }

                authorsAdapter.Update(employeeDataSet, "Employees");
                connection.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}