namespace Odev5
{
    partial class HocaPenceresi
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
            this.txtNewOHocaSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHocaSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewHocaName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHocaAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdateHocaName = new System.Windows.Forms.TextBox();
            this.btnUpdateHoca = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblResultOgrenci = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewOHocaSurname
            // 
            this.txtNewOHocaSurname.Location = new System.Drawing.Point(233, 373);
            this.txtNewOHocaSurname.Name = "txtNewOHocaSurname";
            this.txtNewOHocaSurname.Size = new System.Drawing.Size(142, 22);
            this.txtNewOHocaSurname.TabIndex = 192;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 191;
            this.label1.Text = "Yeni Öğrenci Soyismi";
            // 
            // txtHocaSoyad
            // 
            this.txtHocaSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtHocaSoyad.Location = new System.Drawing.Point(136, 141);
            this.txtHocaSoyad.Name = "txtHocaSoyad";
            this.txtHocaSoyad.Size = new System.Drawing.Size(140, 22);
            this.txtHocaSoyad.TabIndex = 189;
            this.txtHocaSoyad.Text = "Fakülte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 188;
            this.label5.Text = "Soyisim : ";
            // 
            // txtNewHocaName
            // 
            this.txtNewHocaName.Location = new System.Drawing.Point(233, 345);
            this.txtNewHocaName.Name = "txtNewHocaName";
            this.txtNewHocaName.Size = new System.Drawing.Size(142, 22);
            this.txtNewHocaName.TabIndex = 187;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 16);
            this.label10.TabIndex = 186;
            this.label10.Text = "Yeni Öğrenci İsmi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 16);
            this.label7.TabIndex = 185;
            this.label7.Text = "Güncellemek istediğiniz öğrenci ismini giriniz : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 182;
            this.label6.Text = "Hoca";
            // 
            // txtHocaAd
            // 
            this.txtHocaAd.ForeColor = System.Drawing.Color.Black;
            this.txtHocaAd.Location = new System.Drawing.Point(136, 113);
            this.txtHocaAd.Name = "txtHocaAd";
            this.txtHocaAd.Size = new System.Drawing.Size(140, 22);
            this.txtHocaAd.TabIndex = 181;
            this.txtHocaAd.Text = "Fakülte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 179;
            this.label9.Text = "Sonuç : ";
            // 
            // txtUpdateHocaName
            // 
            this.txtUpdateHocaName.Location = new System.Drawing.Point(63, 310);
            this.txtUpdateHocaName.Name = "txtUpdateHocaName";
            this.txtUpdateHocaName.Size = new System.Drawing.Size(142, 22);
            this.txtUpdateHocaName.TabIndex = 177;
            // 
            // btnUpdateHoca
            // 
            this.btnUpdateHoca.Location = new System.Drawing.Point(438, 294);
            this.btnUpdateHoca.Name = "btnUpdateHoca";
            this.btnUpdateHoca.Size = new System.Drawing.Size(233, 133);
            this.btnUpdateHoca.TabIndex = 176;
            this.btnUpdateHoca.Text = "Güncelle";
            this.btnUpdateHoca.UseVisualStyleBackColor = true;
            this.btnUpdateHoca.Click += new System.EventHandler(this.btnUpdateHoca_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 175;
            this.label11.Text = "İsim:";
            // 
            // lblResultOgrenci
            // 
            this.lblResultOgrenci.AutoSize = true;
            this.lblResultOgrenci.Location = new System.Drawing.Point(128, 494);
            this.lblResultOgrenci.Name = "lblResultOgrenci";
            this.lblResultOgrenci.Size = new System.Drawing.Size(45, 16);
            this.lblResultOgrenci.TabIndex = 174;
            this.lblResultOgrenci.Text = "Sonuç";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(438, 94);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(233, 87);
            this.btnCreate.TabIndex = 173;
            this.btnCreate.Text = "Ekle";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(365, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 22);
            this.label12.TabIndex = 172;
            this.label12.Text = "HOCA";
            // 
            // HocaPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNewOHocaSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHocaSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNewHocaName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHocaAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUpdateHocaName);
            this.Controls.Add(this.btnUpdateHoca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblResultOgrenci);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label12);
            this.Name = "HocaPenceresi";
            this.Size = new System.Drawing.Size(730, 549);
            this.Load += new System.EventHandler(this.HocaPenceresi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewOHocaSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHocaSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewHocaName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHocaAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateHocaName;
        private System.Windows.Forms.Button btnUpdateHoca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblResultOgrenci;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label12;
    }
}
