using Search_Book.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Book.Controllers
{
    public class UserController
    {
        static Database db = new Database();

        public static ArrayList GetAllBooks()
        {
            return db.Books.GetAllBooks();
        }

        public static ArrayList SearchBooks(string sb)
        {
            return db.Books.SearchBooks(sb);
        }
    }
}
