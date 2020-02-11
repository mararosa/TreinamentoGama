using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository
{
    public class SqlConnectionFactory
    {
        public static SqlConnection Create() ////esse metodo eh estatico. Sobe inteiro para a memoria
        {
            #region  colocar connection string      
            #endregion

            return new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Integrated Security=True;Database=GAMA_REDE_SOCIAL");
        }

    }
}
