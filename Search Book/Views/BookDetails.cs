using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Search_Book.Models;

namespace Search_Book.Views
{
    public partial class BookDetails : Form
    {
        public BookDetails(Book b)
        {
            InitializeComponent();
            textBoxBookName.Text = b.Name;
            textBoxBookId.Text = b.Id.ToString();
            textBoxAuthorName.Text = b.Author;
            textBoxEdition.Text = b.Edition;
        }
        
        private void BookDetails_Load(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBoxBookId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
