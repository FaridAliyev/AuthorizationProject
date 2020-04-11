using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLgnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(this);
            register.Show();
        }

        private void chbLoginShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLoginShowPassword.Checked)
            {
                txtLoginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
