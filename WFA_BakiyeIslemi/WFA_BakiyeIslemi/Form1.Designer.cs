
namespace WFA_BakiyeIslemi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.grpParaCek = new System.Windows.Forms.GroupBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.nudParaCek = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.grpParaYatir = new System.Windows.Forms.GroupBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.nudParaYatir = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lstIslem = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPeynir = new System.Windows.Forms.CheckBox();
            this.chkCikolata = new System.Windows.Forms.CheckBox();
            this.chkCay = new System.Windows.Forms.CheckBox();
            this.chkYumurta = new System.Windows.Forms.CheckBox();
            this.chkEkmek = new System.Windows.Forms.CheckBox();
            this.lstAlisveris = new System.Windows.Forms.ListBox();
            this.btnAlisveris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.grpParaCek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaCek)).BeginInit();
            this.grpParaYatir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaYatir)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bakiye";
            // 
            // lblTutar
            // 
            this.lblTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutar.Location = new System.Drawing.Point(92, 35);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(207, 49);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.Text = "0.00 TL";
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpParaCek
            // 
            this.grpParaCek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpParaCek.Controls.Add(this.btnParaCek);
            this.grpParaCek.Controls.Add(this.nudParaCek);
            this.grpParaCek.Controls.Add(this.label2);
            this.grpParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpParaCek.Location = new System.Drawing.Point(36, 100);
            this.grpParaCek.Name = "grpParaCek";
            this.grpParaCek.Size = new System.Drawing.Size(161, 131);
            this.grpParaCek.TabIndex = 1;
            this.grpParaCek.TabStop = false;
            this.grpParaCek.Text = "Para Cek";
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(68, 83);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(75, 23);
            this.btnParaCek.TabIndex = 2;
            this.btnParaCek.Text = "Para Cek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // nudParaCek
            // 
            this.nudParaCek.Location = new System.Drawing.Point(52, 29);
            this.nudParaCek.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudParaCek.Name = "nudParaCek";
            this.nudParaCek.Size = new System.Drawing.Size(100, 22);
            this.nudParaCek.TabIndex = 1;
            this.nudParaCek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Miktar:";
            // 
            // grpParaYatir
            // 
            this.grpParaYatir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpParaYatir.Controls.Add(this.btnParaYatir);
            this.grpParaYatir.Controls.Add(this.nudParaYatir);
            this.grpParaYatir.Controls.Add(this.label3);
            this.grpParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpParaYatir.Location = new System.Drawing.Point(203, 100);
            this.grpParaYatir.Name = "grpParaYatir";
            this.grpParaYatir.Size = new System.Drawing.Size(165, 131);
            this.grpParaYatir.TabIndex = 1;
            this.grpParaYatir.TabStop = false;
            this.grpParaYatir.Text = "Para Yatir";
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(61, 83);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(75, 23);
            this.btnParaYatir.TabIndex = 2;
            this.btnParaYatir.Text = "Para Yatir";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // nudParaYatir
            // 
            this.nudParaYatir.Location = new System.Drawing.Point(51, 27);
            this.nudParaYatir.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudParaYatir.Name = "nudParaYatir";
            this.nudParaYatir.Size = new System.Drawing.Size(105, 22);
            this.nudParaYatir.TabIndex = 1;
            this.nudParaYatir.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar:";
            // 
            // lstIslem
            // 
            this.lstIslem.FormattingEnabled = true;
            this.lstIslem.Location = new System.Drawing.Point(36, 239);
            this.lstIslem.Name = "lstIslem";
            this.lstIslem.Size = new System.Drawing.Size(332, 199);
            this.lstIslem.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPeynir);
            this.groupBox1.Controls.Add(this.chkCikolata);
            this.groupBox1.Controls.Add(this.chkCay);
            this.groupBox1.Controls.Add(this.chkYumurta);
            this.groupBox1.Controls.Add(this.chkEkmek);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(500, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkPeynir
            // 
            this.chkPeynir.AutoSize = true;
            this.chkPeynir.Location = new System.Drawing.Point(23, 118);
            this.chkPeynir.Name = "chkPeynir";
            this.chkPeynir.Size = new System.Drawing.Size(109, 20);
            this.chkPeynir.TabIndex = 0;
            this.chkPeynir.Text = "Peynir (45 TL)";
            this.chkPeynir.UseVisualStyleBackColor = true;
            // 
            // chkCikolata
            // 
            this.chkCikolata.AutoSize = true;
            this.chkCikolata.Location = new System.Drawing.Point(23, 95);
            this.chkCikolata.Name = "chkCikolata";
            this.chkCikolata.Size = new System.Drawing.Size(120, 20);
            this.chkCikolata.TabIndex = 0;
            this.chkCikolata.Text = "Cikolata (30 TL)";
            this.chkCikolata.UseVisualStyleBackColor = true;
            // 
            // chkCay
            // 
            this.chkCay.AutoSize = true;
            this.chkCay.Location = new System.Drawing.Point(23, 72);
            this.chkCay.Name = "chkCay";
            this.chkCay.Size = new System.Drawing.Size(123, 20);
            this.chkCay.TabIndex = 0;
            this.chkCay.Text = "Cay (1 kg 35 TL)";
            this.chkCay.UseVisualStyleBackColor = true;
            // 
            // chkYumurta
            // 
            this.chkYumurta.AutoSize = true;
            this.chkYumurta.Location = new System.Drawing.Point(23, 49);
            this.chkYumurta.Name = "chkYumurta";
            this.chkYumurta.Size = new System.Drawing.Size(167, 20);
            this.chkYumurta.TabIndex = 0;
            this.chkYumurta.Text = "Yumurta (10 adet 20 TL)";
            this.chkYumurta.UseVisualStyleBackColor = true;
            // 
            // chkEkmek
            // 
            this.chkEkmek.AutoSize = true;
            this.chkEkmek.Location = new System.Drawing.Point(23, 26);
            this.chkEkmek.Name = "chkEkmek";
            this.chkEkmek.Size = new System.Drawing.Size(106, 20);
            this.chkEkmek.TabIndex = 0;
            this.chkEkmek.Text = "Ekmek (4 TL)";
            this.chkEkmek.UseVisualStyleBackColor = true;
            // 
            // lstAlisveris
            // 
            this.lstAlisveris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAlisveris.FormattingEnabled = true;
            this.lstAlisveris.ItemHeight = 16;
            this.lstAlisveris.Location = new System.Drawing.Point(436, 258);
            this.lstAlisveris.Name = "lstAlisveris";
            this.lstAlisveris.Size = new System.Drawing.Size(324, 180);
            this.lstAlisveris.TabIndex = 4;
            // 
            // btnAlisveris
            // 
            this.btnAlisveris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlisveris.Location = new System.Drawing.Point(523, 214);
            this.btnAlisveris.Name = "btnAlisveris";
            this.btnAlisveris.Size = new System.Drawing.Size(163, 38);
            this.btnAlisveris.TabIndex = 5;
            this.btnAlisveris.Text = "Alisverisi Tamamla";
            this.btnAlisveris.UseVisualStyleBackColor = true;
            this.btnAlisveris.Click += new System.EventHandler(this.btnAlisveris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toplam:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplam.Location = new System.Drawing.Point(588, 175);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(48, 15);
            this.lblToplam.TabIndex = 6;
            this.lblToplam.Text = "0.00 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAlisveris);
            this.Controls.Add(this.lstAlisveris);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstIslem);
            this.Controls.Add(this.grpParaYatir);
            this.Controls.Add(this.grpParaCek);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpParaCek.ResumeLayout(false);
            this.grpParaCek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaCek)).EndInit();
            this.grpParaYatir.ResumeLayout(false);
            this.grpParaYatir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaYatir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.GroupBox grpParaCek;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.NumericUpDown nudParaCek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpParaYatir;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.NumericUpDown nudParaYatir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstIslem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPeynir;
        private System.Windows.Forms.CheckBox chkCikolata;
        private System.Windows.Forms.CheckBox chkCay;
        private System.Windows.Forms.CheckBox chkYumurta;
        private System.Windows.Forms.CheckBox chkEkmek;
        private System.Windows.Forms.ListBox lstAlisveris;
        private System.Windows.Forms.Button btnAlisveris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplam;
    }
}

