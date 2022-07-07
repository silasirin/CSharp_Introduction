
namespace WFA_Abstraction
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstKeman = new System.Windows.Forms.ListBox();
            this.lstKlasikGitar = new System.Windows.Forms.ListBox();
            this.lstPiyano = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 31);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 276);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstKeman
            // 
            this.lstKeman.FormattingEnabled = true;
            this.lstKeman.ItemHeight = 16;
            this.lstKeman.Location = new System.Drawing.Point(355, 31);
            this.lstKeman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstKeman.Name = "lstKeman";
            this.lstKeman.Size = new System.Drawing.Size(224, 116);
            this.lstKeman.TabIndex = 0;
            // 
            // lstKlasikGitar
            // 
            this.lstKlasikGitar.FormattingEnabled = true;
            this.lstKlasikGitar.ItemHeight = 16;
            this.lstKlasikGitar.Location = new System.Drawing.Point(615, 31);
            this.lstKlasikGitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstKlasikGitar.Name = "lstKlasikGitar";
            this.lstKlasikGitar.Size = new System.Drawing.Size(224, 116);
            this.lstKlasikGitar.TabIndex = 0;
            // 
            // lstPiyano
            // 
            this.lstPiyano.FormattingEnabled = true;
            this.lstPiyano.ItemHeight = 16;
            this.lstPiyano.Location = new System.Drawing.Point(873, 31);
            this.lstPiyano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPiyano.Name = "lstPiyano";
            this.lstPiyano.Size = new System.Drawing.Size(224, 116);
            this.lstPiyano.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 554);
            this.Controls.Add(this.lstPiyano);
            this.Controls.Add(this.lstKlasikGitar);
            this.Controls.Add(this.lstKeman);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lstKeman;
        private System.Windows.Forms.ListBox lstKlasikGitar;
        private System.Windows.Forms.ListBox lstPiyano;
    }
}

