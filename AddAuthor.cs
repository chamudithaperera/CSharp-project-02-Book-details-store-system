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
    public partial class AddAuthor : Form
    {

        Dashboard dashboard = null;
        
        public AddAuthor(Dashboard dashboardObj)
        {
            InitializeComponent();
            this.dashboard = dashboardObj;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gender = radioButtonMale.Checked ? "Male" : "Female";
            Author author = new Author(txtName.Text,numericUpDownAge.Value.ToString(), dateTimePickerDOB.Value,gender, pictureBoxImage.Image );

            dashboard.Authors[dashboard.curAuthInd] = author;
            
            MessageBox.Show("Author added");
            dashboard.Show();
            this.Hide();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK )
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
        }
    }
}
