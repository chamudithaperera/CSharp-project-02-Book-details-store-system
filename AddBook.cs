using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Mara_Publication
{
    public partial class AddBook : Form
    {
        Dashboard dashboard = null;

        public AddBook(Dashboard dashboardObj)
        {
            InitializeComponent();
            this.dashboard = dashboardObj;
            
            foreach (var author in this.dashboard.Authors) {
                if(author != null) { 
                    comboBoxAuthors.Items.Add(author.Name);
                }
                    
            }
           
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book(txttitle.Text, comboBoxAuthors.SelectedItem.ToString(), txtEdition.Text, numericUpDownPrice.Value.ToString(),numericUpDownPages.Value.ToString(), numericUpDownCoppies.Value.ToString(), pictureBoxImage.Image);
            dashboard.Books[dashboard.curBookInd] = book;
            MessageBox.Show("Book added");
            dashboard.Show();
            this.Hide();

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                pictureBoxImage.Image = Image.FromFile(openFileDialog.FileName);
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
    
    }
}
