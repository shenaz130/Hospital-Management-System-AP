using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangementSystem
{
    class Connection
    {
        public class Connection
        {
            private static String connectionString = "server=localhost;database=hmsdb;Uid=root;Pwd=;";
            private static MySqlConnection con = null;

            public static MySqlConnection getConnection()
            {
                if (con == null)
                {
                    con = new MySqlConnection(connectionString);
                    con.Open();
                    return con;
                }
                else
                {
                    return con;
                }
            }


        }

        internal static MySqlConnection getConnection()
        {
            throw new NotImplementedException();
        }
    }
}
