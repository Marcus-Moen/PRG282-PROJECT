using System;

namespace StudentManagementSystem.PresentationLayer
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.pbxLogo = new Krypton.Toolkit.KryptonPictureBox();
            this.txtPassword = new Krypton.Toolkit.KryptonTextBox();
            this.btnLogin = new Krypton.Toolkit.KryptonButton();
            this.lblUsername = new Krypton.Toolkit.KryptonLabel();
            this.lblPassword = new Krypton.Toolkit.KryptonLabel();
            this.cbxShowPassword = new Krypton.Toolkit.KryptonCheckBox();
            this.lblWelcome = new Krypton.Toolkit.KryptonLabel();
            this.pnlRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(254, 165);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtUsername.Size = new System.Drawing.Size(255, 44);
            this.txtUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.Rounding = 10F;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.TabIndex = 1;
            // 
            // pnlRed
            // 
            this.pnlRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlRed.BackColor = System.Drawing.Color.Salmon;
            this.pnlRed.Controls.Add(this.pbxLogo);
            this.pnlRed.Location = new System.Drawing.Point(0, 0);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(164, 578);
            this.pnlRed.TabIndex = 2;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(149, 117);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(254, 247);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(255, 44);
            this.txtPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateCommon.Border.Rounding = 10F;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            this.btnLogin.CornerRoundingRadius = 20F;
            this.btnLogin.Location = new System.Drawing.Point(267, 333);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.btnLogin.Size = new System.Drawing.Size(226, 50);
            this.btnLogin.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateCommon.Border.Rounding = 20F;
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Values.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(254, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 24);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Values.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(254, 217);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 24);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Values.Text = "Password:";
            // 
            // cbxShowPassword
            // 
            this.cbxShowPassword.Location = new System.Drawing.Point(267, 297);
            this.cbxShowPassword.Name = "cbxShowPassword";
            this.cbxShowPassword.Size = new System.Drawing.Size(130, 24);
            this.cbxShowPassword.TabIndex = 7;
            this.cbxShowPassword.Values.Text = "Show Password";
            this.cbxShowPassword.CheckedChanged += new System.EventHandler(this.cbxShowPassword_CheckedChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblWelcome.Location = new System.Drawing.Point(213, 52);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(357, 35);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Values.ExtraText = "Student Management System";
            this.lblWelcome.Values.Text = "Welcome";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 469);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.cbxShowPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pnlRed);
            this.Controls.Add(this.txtUsername);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365Black;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlRed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private System.Windows.Forms.Panel pnlRed;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Krypton.Toolkit.KryptonLabel lblUsername;
        private Krypton.Toolkit.KryptonLabel lblPassword;
        private Krypton.Toolkit.KryptonCheckBox cbxShowPassword;
        private Krypton.Toolkit.KryptonLabel lblWelcome;
        private Krypton.Toolkit.KryptonPictureBox pbxLogo;
    }
}