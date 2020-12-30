using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Search_Book.Controllers;

namespace Search_Book.Views
{
    public partial class AllBooks : Form
    {
        public AllBooks()
        {
            InitializeComponent();
            var ds = UserController.GetAllBooks();
            dataGridView1.DataSource = ds;
        }

        private void labelBookSearch_Click(object sender, EventArgs e)
        {

        }

        private void AllBooks_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Author = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string Edition = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
            BookDetails bd = new BookDetails(Id, Name, Author, Edition);
            bd.Show();
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string sb = textBoxSearch.Text;
            var ds = UserController.SearchBooks(sb);
            dataGridView1.DataSource = ds;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
