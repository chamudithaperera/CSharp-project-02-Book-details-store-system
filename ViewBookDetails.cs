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
    public partial class ViewBookDetails : Form
    {
        Dashboard dashboard = null;

        public ViewBookDetails(Dashboard dashboardObj)
        {
            InitializeComponent();
            this.dashboard = dashboardObj;

            foreach (var book in this.dashboard.Books)
            {
                if(book != null)
                {
                    comboBoxTitles.Items.Add(book.Title);
                }
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (dashboard == null || dashboard.IsDisposed)
            {
                dashboard = new Dashboard();
            }

            dashboard.Show();
            this.Hide();    
        }

        private void comboBoxTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book selectedBook = dashboard.Books[comboBoxTitles.SelectedIndex];
            txtBookEdition.Text = selectedBook.Edition != "" ? selectedBook.Edition : "";
            txtBookPrice.Text = selectedBook.Price != ""? selectedBook.Price : "";
            txtNoPage.Text = selectedBook.NoOfPages != "" ? selectedBook.NoOfPages : "";
            txtNoCoppies.Text = selectedBook.NoOfCopies != "" ? selectedBook.NoOfCopies : "";
            pictureBoxBook.Image = selectedBook.Image;

            string selectedAuthorName = selectedBook.Author;
            foreach(var author in dashboard.Authors)
            {
                if(author != null && author.Name == selectedAuthorName)
                {
                    Author selectedAuthor = author;
                    txtName.Text = selectedAuthor.Name;
                    txtDob.Text = selectedAuthor.DOB.ToString();
                    txtAge.Text = selectedAuthor.Age;
                    txtSex.Text = selectedAuthor.Sex;
                    pictureBoxAuthor.Image = selectedAuthor.Image;
                }
            }
        }
    }
}
