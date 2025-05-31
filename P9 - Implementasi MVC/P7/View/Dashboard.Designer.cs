namespace P7
{
    partial class Dashboard
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
            panel3 = new Panel();
            label5 = new Label();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            panel4 = new Panel();
            panel7 = new Panel();
            Ltotalpengeluaran = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel6 = new Panel();
            Lsisasaldo = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            Ltotalpemasukan = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(plotView1);
            panel3.Location = new Point(255, 187);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(816, 379);
            panel3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(282, 25);
            label5.Name = "label5";
            label5.Size = new Size(301, 23);
            label5.TabIndex = 3;
            label5.Text = "Grafik Pemasukan vs Pengeluaran";
            // 
            // plotView1
            // 
            plotView1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plotView1.ForeColor = Color.IndianRed;
            plotView1.Location = new Point(32, 51);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(754, 311);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(255, 59);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(816, 123);
            panel4.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LavenderBlush;
            panel7.Controls.Add(Ltotalpengeluaran);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(pictureBox3);
            panel7.Location = new Point(282, 15);
            panel7.Name = "panel7";
            panel7.Size = new Size(253, 94);
            panel7.TabIndex = 1;
            // 
            // Ltotalpengeluaran
            // 
            Ltotalpengeluaran.AutoSize = true;
            Ltotalpengeluaran.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ltotalpengeluaran.ForeColor = Color.IndianRed;
            Ltotalpengeluaran.Location = new Point(87, 39);
            Ltotalpengeluaran.Name = "Ltotalpengeluaran";
            Ltotalpengeluaran.Size = new Size(20, 23);
            Ltotalpengeluaran.TabIndex = 3;
            Ltotalpengeluaran.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(87, 11);
            label3.Name = "label3";
            label3.Size = new Size(143, 19);
            label3.TabIndex = 2;
            label3.Text = "Total Pengeluaran";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icon_pengeluaran;
            pictureBox3.Location = new Point(17, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 51);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LavenderBlush;
            panel6.Controls.Add(Lsisasaldo);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(pictureBox4);
            panel6.Location = new Point(549, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(253, 94);
            panel6.TabIndex = 1;
            // 
            // Lsisasaldo
            // 
            Lsisasaldo.AutoSize = true;
            Lsisasaldo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lsisasaldo.ForeColor = Color.IndianRed;
            Lsisasaldo.Location = new Point(87, 39);
            Lsisasaldo.Name = "Lsisasaldo";
            Lsisasaldo.Size = new Size(20, 23);
            Lsisasaldo.TabIndex = 4;
            Lsisasaldo.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(87, 11);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 3;
            label4.Text = "Sisa Saldo";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.icon_saldo;
            pictureBox4.Location = new Point(17, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 51);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LavenderBlush;
            panel5.Controls.Add(Ltotalpemasukan);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(15, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(253, 94);
            panel5.TabIndex = 0;
            // 
            // Ltotalpemasukan
            // 
            Ltotalpemasukan.AutoSize = true;
            Ltotalpemasukan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ltotalpemasukan.ForeColor = Color.IndianRed;
            Ltotalpemasukan.Location = new Point(87, 39);
            Ltotalpemasukan.Name = "Ltotalpemasukan";
            Ltotalpemasukan.Size = new Size(20, 23);
            Ltotalpemasukan.TabIndex = 2;
            Ltotalpemasukan.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(87, 11);
            label2.Name = "label2";
            label2.Size = new Size(133, 19);
            label2.TabIndex = 1;
            label2.Text = "Total Pemasukan";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icon_pemasukan;
            pictureBox2.Location = new Point(17, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 51);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleVioletRed;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(-1, 50);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 528);
            panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vecteezy_pink_bills_money___1_;
            pictureBox1.Location = new Point(46, 35);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 124);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleVioletRed;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(22, 310);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(200, 40);
            button3.TabIndex = 2;
            button3.Text = "Keluar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(22, 252);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(200, 40);
            button2.TabIndex = 1;
            button2.Text = "Transaksi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 193);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleVioletRed;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 50);
            panel1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1048, 9);
            label7.Name = "label7";
            label7.Size = new Size(20, 23);
            label7.TabIndex = 3;
            label7.Text = "x";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 23);
            label1.TabIndex = 0;
            label1.Text = "Sistem Manajemen Keuangan";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 576);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label Ltotalpemasukan;
        private Label Ltotalpengeluaran;
        private Label Lsisasaldo;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Label label5;
        private Label label7;
    }
}