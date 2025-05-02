namespace weatherTrail
{
    partial class Weather
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
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.weekbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.currentbtn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txthumidity = new System.Windows.Forms.TextBox();
            this.txtwindk = new System.Windows.Forms.TextBox();
            this.txtmaxtemp = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmintemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.astrobtn = new System.Windows.Forms.Button();
            this.expbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcountry
            // 
            this.txtcountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcountry.Location = new System.Drawing.Point(593, 17);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(256, 20);
            this.txtcountry.TabIndex = 44;
            // 
            // weekbtn
            // 
            this.weekbtn.Location = new System.Drawing.Point(53, 489);
            this.weekbtn.Name = "weekbtn";
            this.weekbtn.Size = new System.Drawing.Size(104, 33);
            this.weekbtn.TabIndex = 43;
            this.weekbtn.Text = "Week";
            this.weekbtn.UseVisualStyleBackColor = true;
            this.weekbtn.Click += new System.EventHandler(this.weekbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(889, 206);
            this.dataGridView1.TabIndex = 42;
            // 
            // currentbtn
            // 
            this.currentbtn.Location = new System.Drawing.Point(672, 232);
            this.currentbtn.Name = "currentbtn";
            this.currentbtn.Size = new System.Drawing.Size(104, 34);
            this.currentbtn.TabIndex = 41;
            this.currentbtn.Text = "Show";
            this.currentbtn.UseVisualStyleBackColor = true;
            this.currentbtn.Click += new System.EventHandler(this.currentbtn_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(699, 53);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(34, 13);
            this.status.TabIndex = 40;
            this.status.Text = "Cloud";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(655, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // txthumidity
            // 
            this.txthumidity.Location = new System.Drawing.Point(275, 212);
            this.txthumidity.Name = "txthumidity";
            this.txthumidity.Size = new System.Drawing.Size(256, 20);
            this.txthumidity.TabIndex = 38;
            this.txthumidity.TextChanged += new System.EventHandler(this.txthumidity_TextChanged);
            // 
            // txtwindk
            // 
            this.txtwindk.Location = new System.Drawing.Point(275, 171);
            this.txtwindk.Name = "txtwindk";
            this.txtwindk.Size = new System.Drawing.Size(256, 20);
            this.txtwindk.TabIndex = 37;
            // 
            // txtmaxtemp
            // 
            this.txtmaxtemp.Location = new System.Drawing.Point(275, 90);
            this.txtmaxtemp.Name = "txtmaxtemp";
            this.txtmaxtemp.Size = new System.Drawing.Size(256, 20);
            this.txtmaxtemp.TabIndex = 36;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(275, 46);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(256, 20);
            this.txtcity.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Humidity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Wind Speed km/h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Max temp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "City";
            // 
            // txtmintemp
            // 
            this.txtmintemp.Location = new System.Drawing.Point(275, 132);
            this.txtmintemp.Name = "txtmintemp";
            this.txtmintemp.Size = new System.Drawing.Size(256, 20);
            this.txtmintemp.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Min temp";
            // 
            // astrobtn
            // 
            this.astrobtn.Location = new System.Drawing.Point(176, 489);
            this.astrobtn.Name = "astrobtn";
            this.astrobtn.Size = new System.Drawing.Size(104, 33);
            this.astrobtn.TabIndex = 47;
            this.astrobtn.Text = "Astronomy";
            this.astrobtn.UseVisualStyleBackColor = true;
            this.astrobtn.Click += new System.EventHandler(this.astrobtn_Click);
            // 
            // expbtn
            // 
            this.expbtn.Location = new System.Drawing.Point(797, 484);
            this.expbtn.Name = "expbtn";
            this.expbtn.Size = new System.Drawing.Size(104, 33);
            this.expbtn.TabIndex = 48;
            this.expbtn.Text = "Export";
            this.expbtn.UseVisualStyleBackColor = true;
            this.expbtn.Click += new System.EventHandler(this.expbtn_Click);
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 534);
            this.Controls.Add(this.expbtn);
            this.Controls.Add(this.astrobtn);
            this.Controls.Add(this.txtmintemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.weekbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.currentbtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txthumidity);
            this.Controls.Add(this.txtwindk);
            this.Controls.Add(this.txtmaxtemp);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Weather";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Weather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.Button weekbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button currentbtn;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txthumidity;
        private System.Windows.Forms.TextBox txtwindk;
        private System.Windows.Forms.TextBox txtmaxtemp;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmintemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button astrobtn;
        private System.Windows.Forms.Button expbtn;
    }
}

