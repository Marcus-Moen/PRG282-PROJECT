namespace StudentManagementSystem
{
    partial class Form1
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
            this.Studentsdgv = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.StudentIdlbl = new System.Windows.Forms.Label();
            this.fullNamelbl = new System.Windows.Forms.Label();
            this.Agelbl = new System.Windows.Forms.Label();
            this.Courselbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Studentsdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Studentsdgv
            // 
            this.Studentsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Studentsdgv.Location = new System.Drawing.Point(364, 24);
            this.Studentsdgv.Name = "Studentsdgv";
            this.Studentsdgv.RowHeadersWidth = 51;
            this.Studentsdgv.RowTemplate.Height = 24;
            this.Studentsdgv.Size = new System.Drawing.Size(641, 349);
            this.Studentsdgv.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 22);
            this.textBox4.TabIndex = 4;
            // 
            // StudentIdlbl
            // 
            this.StudentIdlbl.AutoSize = true;
            this.StudentIdlbl.Location = new System.Drawing.Point(61, 34);
            this.StudentIdlbl.Name = "StudentIdlbl";
            this.StudentIdlbl.Size = new System.Drawing.Size(71, 16);
            this.StudentIdlbl.TabIndex = 5;
            this.StudentIdlbl.Text = "Student ID:";
            // 
            // fullNamelbl
            // 
            this.fullNamelbl.AutoSize = true;
            this.fullNamelbl.Location = new System.Drawing.Point(61, 83);
            this.fullNamelbl.Name = "fullNamelbl";
            this.fullNamelbl.Size = new System.Drawing.Size(71, 16);
            this.fullNamelbl.TabIndex = 6;
            this.fullNamelbl.Text = "Full Name:";
            // 
            // Agelbl
            // 
            this.Agelbl.AutoSize = true;
            this.Agelbl.Location = new System.Drawing.Point(61, 130);
            this.Agelbl.Name = "Agelbl";
            this.Agelbl.Size = new System.Drawing.Size(35, 16);
            this.Agelbl.TabIndex = 7;
            this.Agelbl.Text = "Age:";
            // 
            // Courselbl
            // 
            this.Courselbl.AutoSize = true;
            this.Courselbl.Location = new System.Drawing.Point(61, 181);
            this.Courselbl.Name = "Courselbl";
            this.Courselbl.Size = new System.Drawing.Size(53, 16);
            this.Courselbl.TabIndex = 8;
            this.Courselbl.Text = "Course:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 584);
            this.Controls.Add(this.Courselbl);
            this.Controls.Add(this.Agelbl);
            this.Controls.Add(this.fullNamelbl);
            this.Controls.Add(this.StudentIdlbl);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Studentsdgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Studentsdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Studentsdgv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label StudentIdlbl;
        private System.Windows.Forms.Label fullNamelbl;
        private System.Windows.Forms.Label Agelbl;
        private System.Windows.Forms.Label Courselbl;
    }
}

