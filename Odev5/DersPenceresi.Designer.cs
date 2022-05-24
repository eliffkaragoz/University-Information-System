namespace Odev5
{
    partial class DersPenceresi
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
            this.txtDersName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateDers = new System.Windows.Forms.Button();
            this.lblResultFakulte = new System.Windows.Forms.Label();
            this.btnUpdateDers = new System.Windows.Forms.Button();
            this.txtUpdateDers = new System.Windows.Forms.TextBox();
            this.btnDeleteDers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeleteDersName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewDersName = new System.Windows.Forms.TextBox();
            this.txtHoca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDersName
            // 
            this.txtDersName.Location = new System.Drawing.Point(72, 127);
            this.txtDersName.Name = "txtDersName";
            this.txtDersName.Size = new System.Drawing.Size(123, 22);
            this.txtDersName.TabIndex = 128;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 111;
            this.label6.Text = "DERS";
            // 
            // btnCreateDers
            // 
            this.btnCreateDers.Location = new System.Drawing.Point(379, 95);
            this.btnCreateDers.Name = "btnCreateDers";
            this.btnCreateDers.Size = new System.Drawing.Size(210, 54);
            this.btnCreateDers.TabIndex = 112;
            this.btnCreateDers.Text = "Ekle";
            this.btnCreateDers.UseVisualStyleBackColor = true;
            this.btnCreateDers.Click += new System.EventHandler(this.btnCreateDers_Click);
            // 
            // lblResultFakulte
            // 
            this.lblResultFakulte.AutoSize = true;
            this.lblResultFakulte.Location = new System.Drawing.Point(143, 497);
            this.lblResultFakulte.Name = "lblResultFakulte";
            this.lblResultFakulte.Size = new System.Drawing.Size(45, 16);
            this.lblResultFakulte.TabIndex = 113;
            this.lblResultFakulte.Text = "Sonuç";
            // 
            // btnUpdateDers
            // 
            this.btnUpdateDers.Location = new System.Drawing.Point(379, 320);
            this.btnUpdateDers.Name = "btnUpdateDers";
            this.btnUpdateDers.Size = new System.Drawing.Size(210, 95);
            this.btnUpdateDers.TabIndex = 115;
            this.btnUpdateDers.Text = "Güncelle";
            this.btnUpdateDers.UseVisualStyleBackColor = true;
            this.btnUpdateDers.Click += new System.EventHandler(this.btnUpdateDers_Click);
            // 
            // txtUpdateDers
            // 
            this.txtUpdateDers.Location = new System.Drawing.Point(72, 339);
            this.txtUpdateDers.Name = "txtUpdateDers";
            this.txtUpdateDers.Size = new System.Drawing.Size(142, 22);
            this.txtUpdateDers.TabIndex = 116;
            this.txtUpdateDers.TextChanged += new System.EventHandler(this.txtUpdateDers_TextChanged);
            // 
            // btnDeleteDers
            // 
            this.btnDeleteDers.Location = new System.Drawing.Point(379, 204);
            this.btnDeleteDers.Name = "btnDeleteDers";
            this.btnDeleteDers.Size = new System.Drawing.Size(210, 55);
            this.btnDeleteDers.TabIndex = 117;
            this.btnDeleteDers.Text = "Sil";
            this.btnDeleteDers.UseVisualStyleBackColor = true;
            this.btnDeleteDers.Click += new System.EventHandler(this.btnDeleteDers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 118;
            this.label4.Text = "Sonuç : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 122;
            this.label1.Text = "Ders ismini giriniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 16);
            this.label3.TabIndex = 123;
            this.label3.Text = "Silmek istediğiniz ders ismini giriniz : ";
            // 
            // txtDeleteDersName
            // 
            this.txtDeleteDersName.Location = new System.Drawing.Point(72, 237);
            this.txtDeleteDersName.Name = "txtDeleteDersName";
            this.txtDeleteDersName.Size = new System.Drawing.Size(213, 22);
            this.txtDeleteDersName.TabIndex = 124;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 16);
            this.label7.TabIndex = 125;
            this.label7.Text = "Güncellemek istediğiniz ders ismini giriniz : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 16);
            this.label10.TabIndex = 126;
            this.label10.Text = "Yeni Ders İsmi : ";
            // 
            // txtNewDersName
            // 
            this.txtNewDersName.Location = new System.Drawing.Point(72, 393);
            this.txtNewDersName.Name = "txtNewDersName";
            this.txtNewDersName.Size = new System.Drawing.Size(142, 22);
            this.txtNewDersName.TabIndex = 127;
            // 
            // txtHoca
            // 
            this.txtHoca.Location = new System.Drawing.Point(72, 179);
            this.txtHoca.Name = "txtHoca";
            this.txtHoca.Size = new System.Drawing.Size(123, 22);
            this.txtHoca.TabIndex = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 129;
            this.label2.Text = "Hoca:";
            // 
            // DersPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHoca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDersName);
            this.Controls.Add(this.txtNewDersName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDeleteDersName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteDers);
            this.Controls.Add(this.txtUpdateDers);
            this.Controls.Add(this.btnUpdateDers);
            this.Controls.Add(this.lblResultFakulte);
            this.Controls.Add(this.btnCreateDers);
            this.Controls.Add(this.label6);
            this.Name = "DersPenceresi";
            this.Size = new System.Drawing.Size(792, 609);
            this.Load += new System.EventHandler(this.DersPenceresi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDersName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateDers;
        private System.Windows.Forms.Label lblResultFakulte;
        private System.Windows.Forms.Button btnUpdateDers;
        private System.Windows.Forms.TextBox txtUpdateDers;
        private System.Windows.Forms.Button btnDeleteDers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeleteDersName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNewDersName;
        private System.Windows.Forms.TextBox txtHoca;
        private System.Windows.Forms.Label label2;
    }
}
