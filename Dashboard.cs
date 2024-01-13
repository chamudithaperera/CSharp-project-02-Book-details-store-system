using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mara_Publication
{
    public partial class Dashboard : Form
    {
        private AddAuthor addAuthor = null;
        private Author[] authors = new Author[10];
        public int curAuthInd = -1;

        private AddBook addBook = null;
        private Book[] books = new Book[10];
        public int curBookInd = -1;
        public Dashboard()
        {
            InitializeComponent();
        }        

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            curAuthInd++;
            
            addAuthor = new AddAuthor(this);
            addAuthor.Show();
            this.Hide();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            curBookInd++;
            
            addBook = new AddBook(this);
            addBook.Show();
            this.Hide();
        }
        

        public Author[] Authors
        {
            get { return authors; }
            set { authors = value; }
        }

        public Book[] Books
        {
            get { return books; }
            set { books = value; }
        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            ViewBookDetails viewBookDetails = new ViewBookDetails(this);
            viewBookDetails.Show();

            this.Hide();
        }
    }
}
