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
#warning colocar connection string
            return new SqlConnection("");
        }

    }
}
