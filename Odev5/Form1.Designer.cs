namespace Odev5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListeleme = new System.Windows.Forms.Button();
            this.btnOgrenciDers = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnDers = new System.Windows.Forms.Button();
            this.btnFakulte = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dersPenceresi1 = new Odev5.DersPenceresi();
            this.fakulteBolumPenceresi1 = new Odev5.FakulteBolumPenceresi();
            this.ogrencilerinListelenmesi1 = new Odev5.OgrencilerinListelenmesi();
            this.listelemePenceresi1 = new Odev5.ListelemePenceresi();
            this.ogrenciDersPenceresi1 = new Odev5.OgrenciDersPenceresi();
            this.ogrenciPenecersi1 = new Odev5.OgrenciPenecersi();
            this.btnHoca = new System.Windows.Forms.Button();
            this.hocaPenceresi1 = new Odev5.HocaPenceresi();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnHoca);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnListeleme);
            this.panel1.Controls.Add(this.btnOgrenciDers);
            this.panel1.Controls.Add(this.btnOgrenci);
            this.panel1.Controls.Add(this.btnDers);
            this.panel1.Controls.Add(this.btnFakulte);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 546);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(-38, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Öğrencilerin Listelenmesi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListeleme
            // 
            this.btnListeleme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListeleme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListeleme.FlatAppearance.BorderSize = 0;
            this.btnListeleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListeleme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeleme.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListeleme.Location = new System.Drawing.Point(-21, 300);
            this.btnListeleme.Name = "btnListeleme";
            this.btnListeleme.Size = new System.Drawing.Size(266, 61);
            this.btnListeleme.TabIndex = 19;
            this.btnListeleme.Text = "Derslerin Listelenmesi";
            this.btnListeleme.UseVisualStyleBackColor = false;
            this.btnListeleme.Click += new System.EventHandler(this.btnListeleme_Click);
            // 
            // btnOgrenciDers
            // 
            this.btnOgrenciDers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOgrenciDers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOgrenciDers.FlatAppearance.BorderSize = 0;
            this.btnOgrenciDers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOgrenciDers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenciDers.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOgrenciDers.Location = new System.Drawing.Point(0, 236);
            this.btnOgrenciDers.Name = "btnOgrenciDers";
            this.btnOgrenciDers.Size = new System.Drawing.Size(166, 43);
            this.btnOgrenciDers.TabIndex = 18;
            this.btnOgrenciDers.Text = "Öğrenci-Ders";
            this.btnOgrenciDers.UseVisualStyleBackColor = false;
            this.btnOgrenciDers.Click += new System.EventHandler(this.btnOgrenciDers_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOgrenci.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOgrenci.FlatAppearance.BorderSize = 0;
            this.btnOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOgrenci.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenci.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOgrenci.Location = new System.Drawing.Point(-25, 189);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(166, 41);
            this.btnOgrenci.TabIndex = 17;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.UseVisualStyleBackColor = false;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnDers
            // 
            this.btnDers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDers.FlatAppearance.BorderSize = 0;
            this.btnDers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDers.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDers.Location = new System.Drawing.Point(-25, 122);
            this.btnDers.Name = "btnDers";
            this.btnDers.Size = new System.Drawing.Size(166, 46);
            this.btnDers.TabIndex = 16;
            this.btnDers.Text = "Ders Ekle";
            this.btnDers.UseVisualStyleBackColor = false;
            this.btnDers.Click += new System.EventHandler(this.btnDers_Click);
            // 
            // btnFakulte
            // 
            this.btnFakulte.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFakulte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFakulte.FlatAppearance.BorderSize = 0;
            this.btnFakulte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFakulte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFakulte.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFakulte.Location = new System.Drawing.Point(-4, 73);
            this.btnFakulte.Name = "btnFakulte";
            this.btnFakulte.Size = new System.Drawing.Size(228, 43);
            this.btnFakulte.TabIndex = 15;
            this.btnFakulte.Text = "Fakülte-Bolum Ekle";
            this.btnFakulte.UseVisualStyleBackColor = false;
            this.btnFakulte.Click += new System.EventHandler(this.btnFakulte_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.hocaPenceresi1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dersPenceresi1);
            this.panel2.Controls.Add(this.fakulteBolumPenceresi1);
            this.panel2.Controls.Add(this.ogrencilerinListelenmesi1);
            this.panel2.Controls.Add(this.listelemePenceresi1);
            this.panel2.Controls.Add(this.ogrenciDersPenceresi1);
            this.panel2.Controls.Add(this.ogrenciPenecersi1);
            this.panel2.Location = new System.Drawing.Point(251, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 546);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "OKUL VERİTABANI SİSTEMİ";
            // 
            // dersPenceresi1
            // 
            this.dersPenceresi1.Location = new System.Drawing.Point(33, 0);
            this.dersPenceresi1.Name = "dersPenceresi1";
            this.dersPenceresi1.Size = new System.Drawing.Size(750, 546);
            this.dersPenceresi1.TabIndex = 1;
            this.dersPenceresi1.Load += new System.EventHandler(this.dersPenceresi1_Load);
            // 
            // fakulteBolumPenceresi1
            // 
            this.fakulteBolumPenceresi1.Location = new System.Drawing.Point(37, 0);
            this.fakulteBolumPenceresi1.Name = "fakulteBolumPenceresi1";
            this.fakulteBolumPenceresi1.Size = new System.Drawing.Size(743, 540);
            this.fakulteBolumPenceresi1.TabIndex = 0;
            // 
            // ogrencilerinListelenmesi1
            // 
            this.ogrencilerinListelenmesi1.Location = new System.Drawing.Point(0, 3);
            this.ogrencilerinListelenmesi1.Name = "ogrencilerinListelenmesi1";
            this.ogrencilerinListelenmesi1.Size = new System.Drawing.Size(759, 543);
            this.ogrencilerinListelenmesi1.TabIndex = 6;
            this.ogrencilerinListelenmesi1.Load += new System.EventHandler(this.ogrencilerinListelenmesi1_Load);
            // 
            // listelemePenceresi1
            // 
            this.listelemePenceresi1.Location = new System.Drawing.Point(37, 3);
            this.listelemePenceresi1.Name = "listelemePenceresi1";
            this.listelemePenceresi1.Size = new System.Drawing.Size(746, 537);
            this.listelemePenceresi1.TabIndex = 5;
            // 
            // ogrenciDersPenceresi1
            // 
            this.ogrenciDersPenceresi1.Location = new System.Drawing.Point(24, 0);
            this.ogrenciDersPenceresi1.Name = "ogrenciDersPenceresi1";
            this.ogrenciDersPenceresi1.Size = new System.Drawing.Size(759, 540);
            this.ogrenciDersPenceresi1.TabIndex = 4;
            // 
            // ogrenciPenecersi1
            // 
            this.ogrenciPenecersi1.Location = new System.Drawing.Point(33, 0);
            this.ogrenciPenecersi1.Name = "ogrenciPenecersi1";
            this.ogrenciPenecersi1.Size = new System.Drawing.Size(747, 546);
            this.ogrenciPenecersi1.TabIndex = 3;
            this.ogrenciPenecersi1.Load += new System.EventHandler(this.ogrenciPenecersi1_Load);
            // 
            // btnHoca
            // 
            this.btnHoca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHoca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHoca.FlatAppearance.BorderSize = 0;
            this.btnHoca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHoca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoca.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHoca.Location = new System.Drawing.Point(-51, 437);
            this.btnHoca.Name = "btnHoca";
            this.btnHoca.Size = new System.Drawing.Size(320, 42);
            this.btnHoca.TabIndex = 21;
            this.btnHoca.Text = "HOCA EKLE";
            this.btnHoca.UseVisualStyleBackColor = false;
            this.btnHoca.Click += new System.EventHandler(this.btnHoca_Click);
            // 
            // hocaPenceresi1
            // 
            this.hocaPenceresi1.Location = new System.Drawing.Point(0, -3);
            this.hocaPenceresi1.Name = "hocaPenceresi1";
            this.hocaPenceresi1.Size = new System.Drawing.Size(762, 549);
            this.hocaPenceresi1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnDers;
        private System.Windows.Forms.Button btnFakulte;
        private System.Windows.Forms.Panel panel2;
        private DersPenceresi dersPenceresi1;
        private FakulteBolumPenceresi fakulteBolumPenceresi1;
        private OgrenciPenecersi ogrenciPenecersi1;
        private System.Windows.Forms.Button btnOgrenciDers;
        private OgrenciDersPenceresi ogrenciDersPenceresi1;
        private System.Windows.Forms.Button btnListeleme;
        private ListelemePenceresi listelemePenceresi1;
        private System.Windows.Forms.Button button1;
        private OgrencilerinListelenmesi ogrencilerinListelenmesi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHoca;
        private HocaPenceresi hocaPenceresi1;
    }
}

