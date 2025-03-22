namespace Kilit
{
    partial class girisform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisform));
            this.rd_btn_kız = new System.Windows.Forms.RadioButton();
            this.rd_btn_erkek = new System.Windows.Forms.RadioButton();
            this.lb_cins = new System.Windows.Forms.Label();
            this.lb_isim = new System.Windows.Forms.Label();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rd_btn_kız
            // 
            this.rd_btn_kız.AutoSize = true;
            this.rd_btn_kız.BackColor = System.Drawing.Color.Transparent;
            this.rd_btn_kız.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_btn_kız.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rd_btn_kız.Location = new System.Drawing.Point(591, 123);
            this.rd_btn_kız.Margin = new System.Windows.Forms.Padding(2);
            this.rd_btn_kız.Name = "rd_btn_kız";
            this.rd_btn_kız.Size = new System.Drawing.Size(67, 25);
            this.rd_btn_kız.TabIndex = 14;
            this.rd_btn_kız.TabStop = true;
            this.rd_btn_kız.Text = "Kadın";
            this.rd_btn_kız.UseVisualStyleBackColor = false;
            this.rd_btn_kız.CheckedChanged += new System.EventHandler(this.rd_btn_kız_CheckedChanged);
            // 
            // rd_btn_erkek
            // 
            this.rd_btn_erkek.AutoSize = true;
            this.rd_btn_erkek.BackColor = System.Drawing.Color.Transparent;
            this.rd_btn_erkek.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_btn_erkek.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rd_btn_erkek.Location = new System.Drawing.Point(493, 123);
            this.rd_btn_erkek.Margin = new System.Windows.Forms.Padding(2);
            this.rd_btn_erkek.Name = "rd_btn_erkek";
            this.rd_btn_erkek.Size = new System.Drawing.Size(66, 25);
            this.rd_btn_erkek.TabIndex = 13;
            this.rd_btn_erkek.TabStop = true;
            this.rd_btn_erkek.Text = "Erkek";
            this.rd_btn_erkek.UseVisualStyleBackColor = false;
            this.rd_btn_erkek.CheckedChanged += new System.EventHandler(this.rd_btn_erkek_CheckedChanged);
            // 
            // lb_cins
            // 
            this.lb_cins.AutoSize = true;
            this.lb_cins.BackColor = System.Drawing.Color.Transparent;
            this.lb_cins.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_cins.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lb_cins.Location = new System.Drawing.Point(388, 124);
            this.lb_cins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cins.Name = "lb_cins";
            this.lb_cins.Size = new System.Drawing.Size(68, 21);
            this.lb_cins.TabIndex = 12;
            this.lb_cins.Text = "Cinsiyet:";
            // 
            // lb_isim
            // 
            this.lb_isim.AutoSize = true;
            this.lb_isim.BackColor = System.Drawing.Color.Transparent;
            this.lb_isim.Font = new System.Drawing.Font("Microsoft YaHei", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_isim.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_isim.Location = new System.Drawing.Point(299, 24);
            this.lb_isim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_isim.Name = "lb_isim";
            this.lb_isim.Size = new System.Drawing.Size(57, 26);
            this.lb_isim.TabIndex = 11;
            this.lb_isim.Text = "İsim:";
            // 
            // tx_ad
            // 
            this.tx_ad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tx_ad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_ad.Font = new System.Drawing.Font("Ebrima", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_ad.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tx_ad.Location = new System.Drawing.Point(393, 55);
            this.tx_ad.Margin = new System.Windows.Forms.Padding(2);
            this.tx_ad.Multiline = true;
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(309, 42);
            this.tx_ad.TabIndex = 10;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.SystemColors.WindowText;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.Cyan;
            this.btn_giris.Location = new System.Drawing.Point(794, 74);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(2);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(105, 85);
            this.btn_giris.TabIndex = 9;
            this.btn_giris.Text = "OYNA";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // girisform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 231);
            this.Controls.Add(this.rd_btn_kız);
            this.Controls.Add(this.rd_btn_erkek);
            this.Controls.Add(this.lb_cins);
            this.Controls.Add(this.lb_isim);
            this.Controls.Add(this.tx_ad);
            this.Controls.Add(this.btn_giris);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "girisform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_btn_kız;
        private System.Windows.Forms.RadioButton rd_btn_erkek;
        private System.Windows.Forms.Label lb_cins;
        private System.Windows.Forms.Label lb_isim;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.Button btn_giris;
    }
}