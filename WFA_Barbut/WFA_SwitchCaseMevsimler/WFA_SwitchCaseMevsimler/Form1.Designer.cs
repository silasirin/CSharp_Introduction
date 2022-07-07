
namespace WFA_SwitchCaseMevsimler
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
            this.txtMevsim = new System.Windows.Forms.TextBox();
            this.btnAylar = new System.Windows.Forms.Button();
            this.lblAylar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.txtKontrol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMevsim
            // 
            this.txtMevsim.Location = new System.Drawing.Point(165, 79);
            this.txtMevsim.Name = "txtMevsim";
            this.txtMevsim.Size = new System.Drawing.Size(139, 20);
            this.txtMevsim.TabIndex = 0;
            // 
            // btnAylar
            // 
            this.btnAylar.Location = new System.Drawing.Point(193, 108);
            this.btnAylar.Name = "btnAylar";
            this.btnAylar.Size = new System.Drawing.Size(75, 23);
            this.btnAylar.TabIndex = 1;
            this.btnAylar.Text = "Aylari Getir";
            this.btnAylar.UseVisualStyleBackColor = true;
            this.btnAylar.Click += new System.EventHandler(this.btnAylar_Click);
            // 
            // lblAylar
            // 
            this.lblAylar.Location = new System.Drawing.Point(357, 56);
            this.lblAylar.Name = "lblAylar";
            this.lblAylar.Size = new System.Drawing.Size(100, 75);
            this.lblAylar.TabIndex = 2;
            this.lblAylar.Text = "Aylar";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(190, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mevsim Yazin";
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(497, 108);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(75, 23);
            this.btnKontrol.TabIndex = 3;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // txtKontrol
            // 
            this.txtKontrol.Location = new System.Drawing.Point(483, 79);
            this.txtKontrol.Name = "txtKontrol";
            this.txtKontrol.Size = new System.Drawing.Size(100, 20);
            this.txtKontrol.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(510, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giris Yap";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(188, 265);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(102, 36);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giris";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(165, 212);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(134, 20);
            this.txtKullaniciAdi.TabIndex = 6;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(165, 238);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(134, 20);
            this.txtSifre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kullanici Adi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtKontrol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAylar);
            this.Controls.Add(this.btnAylar);
            this.Controls.Add(this.txtMevsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMevsim;
        private System.Windows.Forms.Button btnAylar;
        private System.Windows.Forms.Label lblAylar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.TextBox txtKontrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

