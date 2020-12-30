using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Book.Models
{
    public class Database
    {
        public Books Books { get; set; }

        public Database()
        {
            string connString = "Server = LAPTOP-V5SVLA1P; Integrated Security = true; Database = SearchBookDB";
            SqlConnection conn = new SqlConnection(connString);
            Books = new Books(conn);
        }

    }
}
