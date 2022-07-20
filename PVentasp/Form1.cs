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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
                //txtUser.Font = new System.Drawing.Font(txtUser.Font, FontStyle.Bold);
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Silver;
                txtUser.Font = new Font("Century Gothic", 12, FontStyle.Italic);
            }

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
                txtPass.Font = new Font("Century Gothic", 12, FontStyle.Italic);

            }

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Usuario")
            {
                if (txtPass.Text != "Contraseña")
                {
                    //// nUsers user = new nUsers();
                    // var validlogin = user.LoginUser(txtUser.Text.Trim(), txtPass.Text);
                    // if (validlogin == true)
                    // {
                    //     this.Hide();
                    //  //   fHome frm = new fHome();
                    //    // frm.FormClosed += Logout;
                    //     //frm.Show();
                    // }
                    // else
                    // {
                    //     msError("Usuario o Contraseña incorrectos. \n Porfavor intente de Nuevo");
                    //     txtPass.Clear();
                    //     txtPass_Enter(null, e);
                    //     //txtPass_Leave(null, e);
                    // }
                    msError("");
                    lblErrorMessage.Visible = false;
                }
                else
                    msError("Porfavor ingrese Contraseña");
            }
            else
                msError("Porfavor ingrese Usuario");
        }

        private void msError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }

    }
}
