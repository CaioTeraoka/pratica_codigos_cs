namespace RC_low_pass_calc
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.ohm = new System.Windows.Forms.ComboBox();
            this.farad = new System.Windows.Forms.ComboBox();
            this.cap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.freq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "RC Low Pass Filter Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resistor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(109, 109);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(100, 20);
            this.res.TabIndex = 2;
            // 
            // ohm
            // 
            this.ohm.FormattingEnabled = true;
            this.ohm.Items.AddRange(new object[] {
            "Ω",
            "KΩ",
            "MΩ"});
            this.ohm.Location = new System.Drawing.Point(215, 109);
            this.ohm.Name = "ohm";
            this.ohm.Size = new System.Drawing.Size(51, 21);
            this.ohm.TabIndex = 3;
            this.ohm.Text = "Ω";
            this.ohm.SelectedIndexChanged += new System.EventHandler(this.ohm_SelectedIndexChanged);
            // 
            // farad
            // 
            this.farad.FormattingEnabled = true;
            this.farad.Items.AddRange(new object[] {
            "F",
            "mF",
            "uF",
            "nF",
            "pF"});
            this.farad.Location = new System.Drawing.Point(215, 152);
            this.farad.Name = "farad";
            this.farad.Size = new System.Drawing.Size(51, 21);
            this.farad.TabIndex = 6;
            this.farad.Text = "F";
            // 
            // cap
            // 
            this.cap.Location = new System.Drawing.Point(109, 152);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(100, 20);
            this.cap.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capacitor";
            // 
            // freq
            // 
            this.freq.Location = new System.Drawing.Point(109, 275);
            this.freq.Name = "freq";
            this.freq.Size = new System.Drawing.Size(100, 20);
            this.freq.TabIndex = 8;
            this.freq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Frequency";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hz";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Calculate.Location = new System.Drawing.Point(116, 219);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(92, 25);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 180);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 365);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.freq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.farad);
            this.Controls.Add(this.cap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ohm);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RC Low Pass Filter Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.ComboBox ohm;
        private System.Windows.Forms.ComboBox farad;
        private System.Windows.Forms.TextBox cap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox freq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

