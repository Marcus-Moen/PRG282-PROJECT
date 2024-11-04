using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace StudentManagementSystem.PresentationLayer
{
    public partial class frmLogin : KryptonForm
    {
        
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            Form1 frm = new Form1();

            frm.ShowDialog();
            this.Close();
        }

        
    }
}
