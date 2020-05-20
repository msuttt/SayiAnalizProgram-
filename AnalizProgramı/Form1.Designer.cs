namespace AnalizProgramı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtRakam = new System.Windows.Forms.RichTextBox();
            this.rtxtSlot = new System.Windows.Forms.RichTextBox();
            this.rtxtAnaliz = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxt1 = new System.Windows.Forms.RichTextBox();
            this.rtxt2 = new System.Windows.Forms.RichTextBox();
            this.rtxt3 = new System.Windows.Forms.RichTextBox();
            this.rtxt4 = new System.Windows.Forms.RichTextBox();
            this.rtxt5 = new System.Windows.Forms.RichTextBox();
            this.rtxt6 = new System.Windows.Forms.RichTextBox();
            this.rtxt7 = new System.Windows.Forms.RichTextBox();
            this.btndosya = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(505, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rakam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(639, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Analiz";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtRakam
            // 
            this.rtxtRakam.BackColor = System.Drawing.Color.White;
            this.rtxtRakam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtxtRakam.Location = new System.Drawing.Point(517, 57);
            this.rtxtRakam.Name = "rtxtRakam";
            this.rtxtRakam.Size = new System.Drawing.Size(40, 32);
            this.rtxtRakam.TabIndex = 3;
            this.rtxtRakam.Text = "";
            // 
            // rtxtSlot
            // 
            this.rtxtSlot.Location = new System.Drawing.Point(584, 57);
            this.rtxtSlot.Name = "rtxtSlot";
            this.rtxtSlot.Size = new System.Drawing.Size(40, 32);
            this.rtxtSlot.TabIndex = 4;
            this.rtxtSlot.Text = "";
            this.rtxtSlot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtSlot_KeyPress);
            // 
            // rtxtAnaliz
            // 
            this.rtxtAnaliz.Location = new System.Drawing.Point(651, 57);
            this.rtxtAnaliz.Name = "rtxtAnaliz";
            this.rtxtAnaliz.Size = new System.Drawing.Size(40, 32);
            this.rtxtAnaliz.TabIndex = 5;
            this.rtxtAnaliz.Text = "";
            this.rtxtAnaliz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtAnaliz_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(572, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Slot";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxt1
            // 
            this.rtxt1.BackColor = System.Drawing.Color.Gainsboro;
            this.rtxt1.ForeColor = System.Drawing.Color.DarkRed;
            this.rtxt1.Location = new System.Drawing.Point(43, 116);
            this.rtxt1.Name = "rtxt1";
            this.rtxt1.Size = new System.Drawing.Size(40, 32);
            this.rtxt1.TabIndex = 7;
            this.rtxt1.Text = "";
            this.rtxt1.Visible = false;
            // 
            // rtxt2
            // 
            this.rtxt2.BackColor = System.Drawing.Color.Gainsboro;
            this.rtxt2.ForeColor = System.Drawing.Color.DarkRed;
            this.rtxt2.Location = new System.Drawing.Point(89, 116);
            this.rtxt2.Name = "rtxt2";
            this.rtxt2.Size = new System.Drawing.Size(40, 32);
            this.rtxt2.TabIndex = 8;
            this.rtxt2.Text = "";
            this.rtxt2.Visible = false;
            // 
            // rtxt3
            // 
            this.rtxt3.BackColor = System.Drawing.Color.Gainsboro;
            this.rtxt3.ForeColor = System.Drawing.Color.DarkRed;
            this.rtxt3.Location = new System.Drawing.Point(135, 116);
            this.rtxt3.Name = "rtxt3";
            this.rtxt3.Size = new System.Drawing.Size(40, 32);
            this.rtxt3.TabIndex = 9;
            this.rtxt3.Text = "";
            this.rtxt3.Visible = false;
            // 
            // rtxt4
            // 
            this.rtxt4.BackColor = System.Drawing.Color.Gainsboro;
            this.rtxt4.ForeColor = System.Drawing.Color.DarkRed;
            this.rtxt4.Location = new System.Drawing.Point(181, 116);
            this.rtxt4.Name = "rtxt4";
            this.rtxt4.Size = new System.Drawing.Size(40, 32);
            this.rtxt4.TabIndex = 10;
            this.rtxt4.Text = "";
            this.rtxt4.Visible = false;
            // 
            // rtxt5
            // 
            this.rtxt5.BackColor = System.Drawing.Color.Gainsboro;
            this.rtxt5.ForeColor = System.Drawing.Color.DarkRed;
            this.rtxt5.Location = new System.Drawing.Point(227, 116);
            this.rtxt5.Name = "rtxt5";
            this.rtxt5.Size = new System.Drawing.Size(40, 32);
            this.rtxt5.TabIndex = 11;
            this.rtxt5.Text = "";
            this.rtxt5.Visible = false;
            // 
            // rtxt6
            // 
            this.rtxt6.BackColor = System.Drawing.Color.Gainsboro;
            this.rtxt6.ForeColor = System.Drawing.Color.DarkRed;
            this.rtxt6.Location = new System.Drawing.Point(273, 116);
            this.rtxt6.Name = "rtxt6";
            this.rtxt6.Size = new System.Drawing.Size(40, 32);
            this.rtxt6.TabIndex = 12;
            this.rtxt6.Text = "";
            this.rtxt6.Visible = false;
            // 
            // rtxt7
            // 
            this.rtxt7.BackColor = System.Drawing.Color.Gainsboro;
            this.rtxt7.ForeColor = System.Drawing.Color.DarkRed;
            this.rtxt7.Location = new System.Drawing.Point(319, 116);
            this.rtxt7.Name = "rtxt7";
            this.rtxt7.Size = new System.Drawing.Size(40, 32);
            this.rtxt7.TabIndex = 13;
            this.rtxt7.Text = "";
            this.rtxt7.Visible = false;
            // 
            // btndosya
            // 
            this.btndosya.Location = new System.Drawing.Point(237, 24);
            this.btndosya.Name = "btndosya";
            this.btndosya.Size = new System.Drawing.Size(75, 23);
            this.btndosya.TabIndex = 14;
            this.btndosya.Text = "Dosya Aç";
            this.btndosya.UseVisualStyleBackColor = true;
            this.btndosya.Click += new System.EventHandler(this.btndosya_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(273, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 251);
            this.listBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btndosya);
            this.Controls.Add(this.rtxt7);
            this.Controls.Add(this.rtxt6);
            this.Controls.Add(this.rtxt5);
            this.Controls.Add(this.rtxt4);
            this.Controls.Add(this.rtxt3);
            this.Controls.Add(this.rtxt2);
            this.Controls.Add(this.rtxt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtAnaliz);
            this.Controls.Add(this.rtxtSlot);
            this.Controls.Add(this.rtxtRakam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtRakam;
        private System.Windows.Forms.RichTextBox rtxtSlot;
        private System.Windows.Forms.RichTextBox rtxtAnaliz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxt1;
        private System.Windows.Forms.RichTextBox rtxt2;
        private System.Windows.Forms.RichTextBox rtxt3;
        private System.Windows.Forms.RichTextBox rtxt4;
        private System.Windows.Forms.RichTextBox rtxt5;
        private System.Windows.Forms.RichTextBox rtxt6;
        private System.Windows.Forms.RichTextBox rtxt7;
        private System.Windows.Forms.Button btndosya;
        private System.Windows.Forms.ListBox listBox1;
    }
}

