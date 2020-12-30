using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_Book.Views
{
    public partial class BookDetails : Form
    {
        public BookDetails(int Id, string Name, string Author, string Edition)
        {
            InitializeComponent();
            textBoxBookName.Text = Name;
            textBoxBookId.Text = Id.ToString();
            textBoxAuthorName.Text = Author;
            textBoxEdition.Text = Edition;        }
        
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
