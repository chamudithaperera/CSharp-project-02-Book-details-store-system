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
    public partial class Login : Form
    {
        Dashboard dashboard = null;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin123") {
                if (dashboard == null || dashboard.IsDisposed)
                {
                    dashboard = new Dashboard();
                }

                dashboard.Show();
                this.Hide();
            }
        }
    }
}
