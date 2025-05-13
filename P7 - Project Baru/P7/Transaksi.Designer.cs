namespace P7
{
    partial class Transaksi
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            Lcatatan = new TextBox();
            Ljumlah = new TextBox();
            label6 = new Label();
            label5 = new Label();
            Ltanggal = new DateTimePicker();
            Lkategori = new TextBox();
            label4 = new Label();
            label3 = new Label();
            Rbpengeluaran = new RadioButton();
            Rbpemasukan = new RadioButton();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            tipe = new DataGridViewTextBoxColumn();
            kategori = new DataGridViewTextBoxColumn();
            tanggal = new DataGridViewTextBoxColumn();
            jumlah = new DataGridViewTextBoxColumn();
            catatan = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(Lcatatan);
            panel3.Controls.Add(Ljumlah);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(Ltanggal);
            panel3.Controls.Add(Lkategori);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(Rbpengeluaran);
            panel3.Controls.Add(Rbpemasukan);
            panel3.Location = new Point(255, 389);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(816, 177);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.LavenderBlush;
            button6.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(697, 110);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(90, 27);
            button6.TabIndex = 11;
            button6.Text = "Hapus";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LavenderBlush;
            button5.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(697, 70);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(90, 27);
            button5.TabIndex = 10;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LavenderBlush;
            button4.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(697, 29);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(90, 27);
            button4.TabIndex = 9;
            button4.Text = "Tambah";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Lcatatan
            // 
            Lcatatan.BackColor = Color.White;
            Lcatatan.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lcatatan.Location = new Point(438, 114);
            Lcatatan.Margin = new Padding(2);
            Lcatatan.Name = "Lcatatan";
            Lcatatan.Size = new Size(191, 27);
            Lcatatan.TabIndex = 8;
            // 
            // Ljumlah
            // 
            Ljumlah.BackColor = Color.White;
            Ljumlah.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ljumlah.Location = new Point(438, 70);
            Ljumlah.Margin = new Padding(2);
            Ljumlah.Name = "Ljumlah";
            Ljumlah.Size = new Size(191, 27);
            Ljumlah.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(358, 116);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 6;
            label6.Text = "Catatan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(358, 72);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 5;
            label5.Text = "Jumlah";
            // 
            // Ltanggal
            // 
            Ltanggal.CustomFormat = "yyyy-MM-dd";
            Ltanggal.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ltanggal.Format = DateTimePickerFormat.Custom;
            Ltanggal.Location = new Point(112, 114);
            Ltanggal.Margin = new Padding(2);
            Ltanggal.Name = "Ltanggal";
            Ltanggal.Size = new Size(191, 27);
            Ltanggal.TabIndex = 0;
            // 
            // Lkategori
            // 
            Lkategori.BackColor = Color.White;
            Lkategori.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lkategori.Location = new Point(112, 70);
            Lkategori.Margin = new Padding(2);
            Lkategori.Name = "Lkategori";
            Lkategori.Size = new Size(191, 27);
            Lkategori.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 116);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 3;
            label4.Text = "Tanggal";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 72);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 2;
            label3.Text = "Kategori";
            label3.Click += label3_Click;
            // 
            // Rbpengeluaran
            // 
            Rbpengeluaran.AutoSize = true;
            Rbpengeluaran.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rbpengeluaran.Location = new Point(190, 29);
            Rbpengeluaran.Margin = new Padding(2);
            Rbpengeluaran.Name = "Rbpengeluaran";
            Rbpengeluaran.Size = new Size(123, 23);
            Rbpengeluaran.TabIndex = 1;
            Rbpengeluaran.TabStop = true;
            Rbpengeluaran.Text = "Pengeluaran";
            Rbpengeluaran.UseVisualStyleBackColor = true;
            Rbpengeluaran.CheckedChanged += Rbpengeluaran_CheckedChanged;
            // 
            // Rbpemasukan
            // 
            Rbpemasukan.AccessibleName = "";
            Rbpemasukan.AutoSize = true;
            Rbpemasukan.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rbpemasukan.Location = new Point(29, 29);
            Rbpemasukan.Margin = new Padding(2);
            Rbpemasukan.Name = "Rbpemasukan";
            Rbpemasukan.Size = new Size(113, 23);
            Rbpemasukan.TabIndex = 0;
            Rbpemasukan.TabStop = true;
            Rbpemasukan.Text = "Pemasukan";
            Rbpemasukan.UseVisualStyleBackColor = true;
            Rbpemasukan.CheckedChanged += Rbpemasukan_CheckedChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(255, 59);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(816, 325);
            panel4.TabIndex = 7;
            panel4.Paint += panel4_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, tipe, kategori, tanggal, jumlah, catatan });
            dataGridView1.Location = new Point(14, 43);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(789, 266);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            id.Width = 125;
            // 
            // tipe
            // 
            tipe.DataPropertyName = "tipe";
            tipe.HeaderText = "Tipe";
            tipe.MinimumWidth = 6;
            tipe.Name = "tipe";
            tipe.Width = 125;
            // 
            // kategori
            // 
            kategori.DataPropertyName = "kategori";
            kategori.HeaderText = "Kategori";
            kategori.MinimumWidth = 6;
            kategori.Name = "kategori";
            kategori.Width = 125;
            // 
            // tanggal
            // 
            tanggal.DataPropertyName = "tanggal";
            tanggal.HeaderText = "Tanggal";
            tanggal.MinimumWidth = 6;
            tanggal.Name = "tanggal";
            tanggal.Width = 125;
            // 
            // jumlah
            // 
            jumlah.DataPropertyName = "jumlah";
            jumlah.HeaderText = "Jumlah";
            jumlah.MinimumWidth = 6;
            jumlah.Name = "jumlah";
            jumlah.Width = 125;
            // 
            // catatan
            // 
            catatan.DataPropertyName = "catatan";
            catatan.HeaderText = "Catatan";
            catatan.MinimumWidth = 6;
            catatan.Name = "catatan";
            catatan.Width = 225;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 19);
            label2.TabIndex = 0;
            label2.Text = "Data Transaksi";
            label2.Click += label2_Click;
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
            panel2.TabIndex = 6;
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
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleVioletRed;
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 50);
            panel1.TabIndex = 5;
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
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 576);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Transaksi";
            Text = "Transaksi";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private RadioButton Rbpengeluaran;
        private RadioButton Rbpemasukan;
        private Label label4;
        private Label label5;
        private DateTimePicker Ltanggal;
        private TextBox Lkategori;
        private Button button4;
        private TextBox Lcatatan;
        private TextBox Ljumlah;
        private Label label6;
        private Button button6;
        private Button button5;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn tipe;
        private DataGridViewTextBoxColumn kategori;
        private DataGridViewTextBoxColumn tanggal;
        private DataGridViewTextBoxColumn jumlah;
        private DataGridViewTextBoxColumn catatan;
    }
}