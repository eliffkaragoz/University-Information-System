namespace Odev5
{
    partial class OgrenciDersPenceresi
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblResultOgrenci = new System.Windows.Forms.Label();
            this.btnCreateOgrenciDers = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYarıyıl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.lblResultOgrenciDers = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOgrenciName = new System.Windows.Forms.TextBox();
            this.txtDersName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 16);
            this.label6.TabIndex = 180;
            this.label6.Text = "Aşağıdaki Bilgileri Giriniz:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 178;
            this.label8.Text = "Ders Adı:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 618);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 177;
            this.label9.Text = "Sonuç : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(97, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 173;
            this.label11.Text = "Öğrenci Adı: ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblResultOgrenci
            // 
            this.lblResultOgrenci.AutoSize = true;
            this.lblResultOgrenci.Location = new System.Drawing.Point(165, 618);
            this.lblResultOgrenci.Name = "lblResultOgrenci";
            this.lblResultOgrenci.Size = new System.Drawing.Size(45, 16);
            this.lblResultOgrenci.TabIndex = 172;
            this.lblResultOgrenci.Text = "Sonuç";
            // 
            // btnCreateOgrenciDers
            // 
            this.btnCreateOgrenciDers.Location = new System.Drawing.Point(97, 368);
            this.btnCreateOgrenciDers.Name = "btnCreateOgrenciDers";
            this.btnCreateOgrenciDers.Size = new System.Drawing.Size(254, 67);
            this.btnCreateOgrenciDers.TabIndex = 171;
            this.btnCreateOgrenciDers.Text = "Ekle";
            this.btnCreateOgrenciDers.UseVisualStyleBackColor = true;
            this.btnCreateOgrenciDers.Click += new System.EventHandler(this.btnCreateOgrenciDers_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(306, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 22);
            this.label12.TabIndex = 170;
            this.label12.Text = "ÖĞRENCİ\'YE DERS EKLE";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtYarıyıl
            // 
            this.txtYarıyıl.Location = new System.Drawing.Point(209, 219);
            this.txtYarıyıl.Name = "txtYarıyıl";
            this.txtYarıyıl.Size = new System.Drawing.Size(142, 22);
            this.txtYarıyıl.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 191;
            this.label1.Text = "Yarıyıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 192;
            this.label2.Text = "Vize";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 193;
            this.label3.Text = "Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 194;
            this.label5.Text = "Yıl";
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(209, 254);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(142, 22);
            this.txtVize.TabIndex = 195;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(209, 285);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(142, 22);
            this.txtFinal.TabIndex = 196;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(209, 319);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(142, 22);
            this.txtYil.TabIndex = 197;
            // 
            // lblResultOgrenciDers
            // 
            this.lblResultOgrenciDers.AutoSize = true;
            this.lblResultOgrenciDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultOgrenciDers.Location = new System.Drawing.Point(118, 477);
            this.lblResultOgrenciDers.Name = "lblResultOgrenciDers";
            this.lblResultOgrenciDers.Size = new System.Drawing.Size(62, 16);
            this.lblResultOgrenciDers.TabIndex = 199;
            this.lblResultOgrenciDers.Text = "Sonuç : ";
            this.lblResultOgrenciDers.Click += new System.EventHandler(this.lblResultOgrenciDers_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 198;
            this.label7.Text = "Sonuç";
            // 
            // txtOgrenciName
            // 
            this.txtOgrenciName.Location = new System.Drawing.Point(209, 127);
            this.txtOgrenciName.Name = "txtOgrenciName";
            this.txtOgrenciName.Size = new System.Drawing.Size(142, 22);
            this.txtOgrenciName.TabIndex = 208;
            // 
            // txtDersName
            // 
            this.txtDersName.Location = new System.Drawing.Point(209, 164);
            this.txtDersName.Name = "txtDersName";
            this.txtDersName.Size = new System.Drawing.Size(142, 22);
            this.txtDersName.TabIndex = 209;
            // 
            // OgrenciDersPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDersName);
            this.Controls.Add(this.txtOgrenciName);
            this.Controls.Add(this.lblResultOgrenciDers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYarıyıl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblResultOgrenci);
            this.Controls.Add(this.btnCreateOgrenciDers);
            this.Controls.Add(this.label12);
            this.Name = "OgrenciDersPenceresi";
            this.Size = new System.Drawing.Size(804, 608);
            this.Load += new System.EventHandler(this.OgrenciDersPenceresi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblResultOgrenci;
        private System.Windows.Forms.Button btnCreateOgrenciDers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtYarıyıl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label lblResultOgrenciDers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOgrenciName;
        private System.Windows.Forms.TextBox txtDersName;
    }
}
