namespace StudentManagementSystem.PresentationLayer
{
    partial class frmStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistics));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fpnlNavigationBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pbxLogo = new Krypton.Toolkit.KryptonPictureBox();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbSummary = new Krypton.Toolkit.KryptonGroupBox();
            this.rbTwo = new Krypton.Toolkit.KryptonRadioButton();
            this.rbOne = new Krypton.Toolkit.KryptonRadioButton();
            this.btnSummary = new Krypton.Toolkit.KryptonButton();
            this.rtbSummary = new Krypton.Toolkit.KryptonRichTextBox();
            this.fpnlNavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbSummary.Panel)).BeginInit();
            this.gbSummary.Panel.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlNavigationBar
            // 
            this.fpnlNavigationBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fpnlNavigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fpnlNavigationBar.Controls.Add(this.pbxLogo);
            this.fpnlNavigationBar.Controls.Add(this.btnStudents);
            this.fpnlNavigationBar.Controls.Add(this.btnStatistics);
            this.fpnlNavigationBar.Controls.Add(this.btnLogout);
            this.fpnlNavigationBar.Location = new System.Drawing.Point(-2, 2);
            this.fpnlNavigationBar.Name = "fpnlNavigationBar";
            this.fpnlNavigationBar.Size = new System.Drawing.Size(127, 758);
            this.fpnlNavigationBar.TabIndex = 15;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(101, 56);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // btnStudents
            // 
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(3, 65);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(110, 62);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            this.btnStatistics.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Location = new System.Drawing.Point(3, 133);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(110, 63);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(3, 202);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 63);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlTopBar.Location = new System.Drawing.Point(122, 2);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(966, 42);
            this.pnlTopBar.TabIndex = 16;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(167, 67);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(482, 351);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // gbSummary
            // 
            this.gbSummary.CaptionStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.gbSummary.Location = new System.Drawing.Point(691, 67);
            this.gbSummary.Name = "gbSummary";
            // 
            // gbSummary.Panel
            // 
            this.gbSummary.Panel.Controls.Add(this.rbTwo);
            this.gbSummary.Panel.Controls.Add(this.rbOne);
            this.gbSummary.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox1_Panel_Paint);
            this.gbSummary.Size = new System.Drawing.Size(265, 150);
            this.gbSummary.TabIndex = 18;
            // 
            // rbTwo
            // 
            this.rbTwo.Location = new System.Drawing.Point(23, 48);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(79, 24);
            this.rbTwo.TabIndex = 1;
            this.rbTwo.Values.Text = "Average";
            this.rbTwo.CheckedChanged += new System.EventHandler(this.rbTwo_CheckedChanged);
            // 
            // rbOne
            // 
            this.rbOne.Location = new System.Drawing.Point(23, 15);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(85, 24);
            this.rbOne.TabIndex = 0;
            this.rbOne.Values.Text = "Pie Chart";
            this.rbOne.CheckedChanged += new System.EventHandler(this.rbOne_CheckedChanged);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(716, 477);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(199, 61);
            this.btnSummary.TabIndex = 19;
            this.btnSummary.Values.Text = "Print Summary";
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // rtbSummary
            // 
            this.rtbSummary.Location = new System.Drawing.Point(691, 264);
            this.rtbSummary.Name = "rtbSummary";
            this.rtbSummary.Size = new System.Drawing.Size(321, 183);
            this.rtbSummary.TabIndex = 20;
            this.rtbSummary.Text = "";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 755);
            this.Controls.Add(this.rtbSummary);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.fpnlNavigationBar);
            this.Name = "frmStatistics";
            this.Text = "frmStatistics";
            this.fpnlNavigationBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbSummary.Panel)).EndInit();
            this.gbSummary.Panel.ResumeLayout(false);
            this.gbSummary.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbSummary)).EndInit();
            this.gbSummary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlNavigationBar;
        private Krypton.Toolkit.KryptonPictureBox pbxLogo;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Krypton.Toolkit.KryptonGroupBox gbSummary;
        private Krypton.Toolkit.KryptonRadioButton rbTwo;
        private Krypton.Toolkit.KryptonRadioButton rbOne;
        private Krypton.Toolkit.KryptonButton btnSummary;
        private Krypton.Toolkit.KryptonRichTextBox rtbSummary;
    }
}