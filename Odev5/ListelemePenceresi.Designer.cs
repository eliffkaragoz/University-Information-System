namespace Odev5
{
    partial class ListelemePenceresi
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
            this.txtOgrenciName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.yıl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYariyil = new System.Windows.Forms.TextBox();
            this.btnListeleYil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 180;
            this.label6.Text = "Öğrenci no giriniz:";
            // 
            // txtOgrenciName
            // 
            this.txtOgrenciName.ForeColor = System.Drawing.Color.Black;
            this.txtOgrenciName.Location = new System.Drawing.Point(252, 62);
            this.txtOgrenciName.Name = "txtOgrenciName";
            this.txtOgrenciName.Size = new System.Drawing.Size(140, 22);
            this.txtOgrenciName.TabIndex = 179;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 177;
            this.label9.Text = "Sonuç : ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(156, 99);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 172;
            this.lblResult.Text = "Sonuç";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(444, 55);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(212, 31);
            this.btnListele.TabIndex = 171;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(329, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 22);
            this.label12.TabIndex = 170;
            this.label12.Text = "Öğrenci-Ders Listeleme";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(535, 212);
            this.dataGridView1.TabIndex = 181;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtYil
            // 
            this.txtYil.ForeColor = System.Drawing.Color.Black;
            this.txtYil.Location = new System.Drawing.Point(149, 163);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(140, 22);
            this.txtYil.TabIndex = 182;
            // 
            // yıl
            // 
            this.yıl.AutoSize = true;
            this.yıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yıl.Location = new System.Drawing.Point(79, 166);
            this.yıl.Name = "yıl";
            this.yıl.Size = new System.Drawing.Size(29, 16);
            this.yıl.TabIndex = 183;
            this.yıl.Text = "Yil:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 185;
            this.label1.Text = "Yarı Yil:";
            // 
            // txtYariyil
            // 
            this.txtYariyil.ForeColor = System.Drawing.Color.Black;
            this.txtYariyil.Location = new System.Drawing.Point(149, 191);
            this.txtYariyil.Name = "txtYariyil";
            this.txtYariyil.Size = new System.Drawing.Size(140, 22);
            this.txtYariyil.TabIndex = 184;
            // 
            // btnListeleYil
            // 
            this.btnListeleYil.Location = new System.Drawing.Point(333, 159);
            this.btnListeleYil.Name = "btnListeleYil";
            this.btnListeleYil.Size = new System.Drawing.Size(212, 31);
            this.btnListeleYil.TabIndex = 186;
            this.btnListeleYil.Text = "Yil a göre listele";
            this.btnListeleYil.UseVisualStyleBackColor = true;
            this.btnListeleYil.Click += new System.EventHandler(this.btnListeleYil_Click);
            // 
            // ListelemePenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnListeleYil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYariyil);
            this.Controls.Add(this.yıl);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOgrenciName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label12);
            this.Name = "ListelemePenceresi";
            this.Size = new System.Drawing.Size(769, 485);
            this.Load += new System.EventHandler(this.ListelemePenceresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgrenciName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label yıl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYariyil;
        private System.Windows.Forms.Button btnListeleYil;
    }
}
