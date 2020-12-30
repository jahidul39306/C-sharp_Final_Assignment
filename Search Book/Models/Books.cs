using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Book.Models
{
    public class Books
    {
        SqlConnection conn;
        public Books(SqlConnection conn)
        {
            this.conn = conn;
        }
        public ArrayList GetAllBooks()
        {
            ArrayList books = new ArrayList();
            conn.Open();
            String query = "SELECT * FROM Books";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Book book = new Book();
                book.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                book.Name = reader.GetString(reader.GetOrdinal("Name"));
                book.Author = reader.GetString(reader.GetOrdinal("Author"));
                book.Edition = reader.GetString(reader.GetOrdinal("Edition"));

                books.Add(book);

            }
            conn.Close();
            return books;
        }
       
        public ArrayList SearchBooks(string sb)
        {
            ArrayList sBooks = new ArrayList();
            conn.Open();
            string query = ("SELECT * FROM Books Where Name LIKE '%" + sb + "%'");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader1 = cmd.ExecuteReader();
            while(reader1.Read())
            {
                Book book = new Book();
                book.Id = reader1.GetInt32(reader1.GetOrdinal("Id"));
                book.Name = reader1.GetString(reader1.GetOrdinal("Name"));
                book.Author = reader1.GetString(reader1.GetOrdinal("Author"));
                book.Edition = reader1.GetString(reader1.GetOrdinal("Edition"));

                sBooks.Add(book);
            }
            conn.Close();
            return sBooks;
        }


    }
}
