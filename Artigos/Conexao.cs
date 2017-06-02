using System;
using System.Data.SqlClient;
using System.IO;
using System.Data;
//using MySql.Data.MySqlClient;

namespace Artigos
{
    public class Conexao
    {
       SqlConnection conn = null;

        public SqlConnection ConnectToDatabase()  //
        {
            try
            {


               /** conn = new SqlConnection();
                conn.ConnectionString = "SERVER=aplicativo_db.mysql.dbaas.com.br;DATABASE=aplicativo_db;user=aplicativo_db;password=Sector@22";
                conn.Open();
                return conn;*/
                //Criar uma nova instancia
                conn = new SqlConnection();
                var path = AppDomain.CurrentDomain.BaseDirectory?.Replace("bin\\Debug\\", "").Replace("bin\\Release\\", "");

                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ path + "database.mdf;Integrated Security=True;Connect Timeout=30";
                conn.Open();
                return conn; 

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
/**/