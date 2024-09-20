using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PapelariaAris.Resources
{
    internal class Connection
    {
        public SqlConnection con;
        private string DataBase = "PR2CJ3022641BDPapelariairis";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";

        public Connection()
        {
            string stringConnection = @"Serve= " + Server
                + ";Initial Catalog = " + DataBase
                + "; User Id =" + Username
                + "; Password ="+ Password
                + "; Encrypt = false";


            con = new SqlConnection(stringConnection);
            con.Open();

        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public SqlConnection ReturnConnection()
        {
            return con;
        }
               
                


                
        }


    }
}
