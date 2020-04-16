using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexao
{
    public class CrudConnection
    {
        private SqlConnection connection;

    
    public CrudConnection()
    {
            Initialize();
        }

        private void Initialize()
        {
            try
            {
                string connectionString;
                connectionString = @"Data sources=DESKTOP-PV2UP24;Initial Catalog = CADASTRO;";

                connection = new SqlConnection(connectionString);
            }
            catch(Exception ex)
            {
                throw ex;
            }
    }
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch(SqlException)
            {
                return false;
            }

        }
        public bool CloseConnecion()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch(SqlException)
            {
                return false;
            }
        }

    }
}
