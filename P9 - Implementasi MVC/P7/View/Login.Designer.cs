namespace P7
{
    partial class Login
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
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            buttonSignup = new Button();
            label5 = new Label();
            tutup = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            tampilkanpw = new CheckBox();
            buttonLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleVioletRed;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonSignup);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 576);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(98, 228);
            label6.Name = "label6";
            label6.Size = new Size(331, 31);
            label6.TabIndex = 11;
            label6.Text = "Sistem Manajemen Keuangan";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vecteezy_pink_bills_money___1_;
            pictureBox1.Location = new Point(183, 83);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 124);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // buttonSignup
            // 
            buttonSignup.BackColor = Color.White;
            buttonSignup.FlatAppearance.BorderSize = 0;
            buttonSignup.FlatAppearance.MouseDownBackColor = Color.White;
            buttonSignup.FlatAppearance.MouseOverBackColor = Color.White;
            buttonSignup.FlatStyle = FlatStyle.Flat;
            buttonSignup.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSignup.ForeColor = Color.PaleVioletRed;
            buttonSignup.Location = new Point(21, 512);
            buttonSignup.Name = "buttonSignup";
            buttonSignup.Size = new Size(499, 43);
            buttonSignup.TabIndex = 9;
            buttonSignup.Text = "SIGNUP";
            buttonSignup.UseVisualStyleBackColor = false;
            buttonSignup.Click += buttonSignup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(183, 478);
            label5.Name = "label5";
            label5.Size = new Size(178, 22);
            label5.TabIndex = 9;
            label5.Text = "Daftarkan Akun Anda";
            // 
            // tutup
            // 
            tutup.AutoSize = true;
            tutup.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tutup.ForeColor = Color.Black;
            tutup.Location = new Point(1048, 9);
            tutup.Name = "tutup";
            tutup.Size = new Size(20, 23);
            tutup.TabIndex = 1;
            tutup.Text = "x";
            tutup.Click += tutup_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(577, 98);
            label2.Name = "label2";
            label2.Size = new Size(213, 32);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(577, 185);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(577, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(463, 30);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(577, 314);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(463, 30);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(577, 280);
            label4.Name = "label4";
            label4.Size = new Size(94, 22);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // tampilkanpw
            // 
            tampilkanpw.AutoSize = true;
            tampilkanpw.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tampilkanpw.Location = new Point(842, 359);
            tampilkanpw.Name = "tampilkanpw";
            tampilkanpw.Size = new Size(198, 26);
            tampilkanpw.TabIndex = 7;
            tampilkanpw.Text = "Tampilkan Password";
            tampilkanpw.UseVisualStyleBackColor = true;
            tampilkanpw.CheckedChanged += tampilkanpw_CheckedChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.PaleVioletRed;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            buttonLogin.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(577, 417);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(131, 43);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 576);
            Controls.Add(buttonLogin);
            Controls.Add(tampilkanpw);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tutup);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label tutup;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private CheckBox tampilkanpw;
        private Button buttonLogin;
        private Button buttonSignup;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}