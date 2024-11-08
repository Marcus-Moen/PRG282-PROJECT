﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using StudentManagementSystem.BusinessLogicLayer;
using StudentManagementSystem.DataAccessLayer;

namespace StudentManagementSystem.PresentationLayer
{
    public partial class frmLogin : KryptonForm
    {
       
        private Functions Functions = new Functions();
        private FileHandler file = new FileHandler();
         Form1 frm = new Form1();

        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //Reveals password when checked, hides when unchecked
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
            //Signin() function checks if given Username and password are correct and returns a true or false
            if (Functions.signin(file.logins(), txtUsername.Text, txtPassword.Text))
            {
                //Instructions on what to do on next form
                MessageBox.Show("Please enter in the Data Password under under the label and click enter password button");
                
                frm.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Incorrect login Details");
            }

        }

        
    }
}
