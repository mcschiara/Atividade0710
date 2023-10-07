using System;
using System.Data.SqlClient;

namespace Atividade0710
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void connecting()
        {
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; 
                                AttachDbFilename=|DataDirectory|\APP_DATA\Database.mdf; 
                                Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                System.Console.WriteLine("Conexão estabelecida com sucesso");
            }
        }
}

           // public void testaConexao()
            //{
              //  try
               // {
              //      String conString = @"Data Source=(LocalDB)\MSSQLLocalDB; 
              //                  AttachDbFilename=|DataDirectory|\APP_DATA\Database.mdf; 
              //                  Integrated Security = True";
              //      SqlConnection connection = new SqlConnection(conString);
               //     connection.Open();
               //     Console.WriteLine("\nConexão aberta com sucesso!\n");
              //  }
              //  catch (SqlException ex)
               // {
              //      Console.WriteLine($"\nOcorreu uma exceção : {ex.Message}\n");
              //  }
            //}



        }
}
