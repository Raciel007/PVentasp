using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVentasp
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            fUsuarios frm = new fUsuarios();
            frm.FormClosed += Logout;
            frm.Show();

        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
            // txtPass.Focus();
        }

    }
}
