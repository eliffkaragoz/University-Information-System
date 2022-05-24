namespace Odev5
{
    partial class FakulteBolumPenceresi
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
            this.txtFakulteName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteFakulte = new System.Windows.Forms.Button();
            this.txtUpdateBolum = new System.Windows.Forms.TextBox();
            this.btnUpdatebolum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultFakulte = new System.Windows.Forms.Label();
            this.btnCreateFakulte = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBolumName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeleteBolumName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtupdateNewBolum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFakulteName
            // 
            this.txtFakulteName.ForeColor = System.Drawing.Color.Black;
            this.txtFakulteName.Location = new System.Drawing.Point(132, 92);
            this.txtFakulteName.Name = "txtFakulteName";
            this.txtFakulteName.Size = new System.Drawing.Size(140, 22);
            this.txtFakulteName.TabIndex = 102;
            this.txtFakulteName.Text = "Fakülte";
            this.txtFakulteName.TextChanged += new System.EventHandler(this.txtFakulteName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 101;
            this.label8.Text = "Bölüm : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 100;
            this.label4.Text = "Sonuç : ";
            // 
            // btnDeleteFakulte
            // 
            this.btnDeleteFakulte.Location = new System.Drawing.Point(434, 244);
            this.btnDeleteFakulte.Name = "btnDeleteFakulte";
            this.btnDeleteFakulte.Size = new System.Drawing.Size(233, 41);
            this.btnDeleteFakulte.TabIndex = 98;
            this.btnDeleteFakulte.Text = "Sil";
            this.btnDeleteFakulte.UseVisualStyleBackColor = true;
            this.btnDeleteFakulte.Click += new System.EventHandler(this.btnDeleteFakulte_Click);
            // 
            // txtUpdateBolum
            // 
            this.txtUpdateBolum.Location = new System.Drawing.Point(59, 386);
            this.txtUpdateBolum.Name = "txtUpdateBolum";
            this.txtUpdateBolum.Size = new System.Drawing.Size(142, 22);
            this.txtUpdateBolum.TabIndex = 97;
            // 
            // btnUpdatebolum
            // 
            this.btnUpdatebolum.Location = new System.Drawing.Point(434, 367);
            this.btnUpdatebolum.Name = "btnUpdatebolum";
            this.btnUpdatebolum.Size = new System.Drawing.Size(233, 95);
            this.btnUpdatebolum.TabIndex = 96;
            this.btnUpdatebolum.Text = "Güncelle";
            this.btnUpdatebolum.UseVisualStyleBackColor = true;
            this.btnUpdatebolum.Click += new System.EventHandler(this.btnUpdateBolum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Fakulte : ";
            // 
            // lblResultFakulte
            // 
            this.lblResultFakulte.AutoSize = true;
            this.lblResultFakulte.Location = new System.Drawing.Point(124, 517);
            this.lblResultFakulte.Name = "lblResultFakulte";
            this.lblResultFakulte.Size = new System.Drawing.Size(45, 16);
            this.lblResultFakulte.TabIndex = 94;
            this.lblResultFakulte.Text = "Sonuç";
            // 
            // btnCreateFakulte
            // 
            this.btnCreateFakulte.Location = new System.Drawing.Point(434, 73);
            this.btnCreateFakulte.Name = "btnCreateFakulte";
            this.btnCreateFakulte.Size = new System.Drawing.Size(233, 87);
            this.btnCreateFakulte.TabIndex = 92;
            this.btnCreateFakulte.Text = "Ekle";
            this.btnCreateFakulte.UseVisualStyleBackColor = true;
            this.btnCreateFakulte.Click += new System.EventHandler(this.btnCreateFakulte_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 91;
            this.label6.Text = "BÖLÜM";
            // 
            // txtBolumName
            // 
            this.txtBolumName.ForeColor = System.Drawing.Color.Black;
            this.txtBolumName.Location = new System.Drawing.Point(132, 138);
            this.txtBolumName.Name = "txtBolumName";
            this.txtBolumName.Size = new System.Drawing.Size(140, 22);
            this.txtBolumName.TabIndex = 103;
            this.txtBolumName.TextChanged += new System.EventHandler(this.txtBolumName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "Bölüm ve Fakülte ismini giriniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "Silmek istediğiniz bölüm ismini giriniz : ";
            // 
            // txtDeleteBolumName
            // 
            this.txtDeleteBolumName.Location = new System.Drawing.Point(59, 263);
            this.txtDeleteBolumName.Name = "txtDeleteBolumName";
            this.txtDeleteBolumName.Size = new System.Drawing.Size(213, 22);
            this.txtDeleteBolumName.TabIndex = 106;
            this.txtDeleteBolumName.TextChanged += new System.EventHandler(this.txtDeleteBolumName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 16);
            this.label7.TabIndex = 107;
            this.label7.Text = "Güncellemek istediğiniz bölüm ismini giriniz : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 16);
            this.label10.TabIndex = 109;
            this.label10.Text = "Yeni Bölüm İsmi : ";
            // 
            // txtupdateNewBolum
            // 
            this.txtupdateNewBolum.Location = new System.Drawing.Point(59, 440);
            this.txtupdateNewBolum.Name = "txtupdateNewBolum";
            this.txtupdateNewBolum.Size = new System.Drawing.Size(142, 22);
            this.txtupdateNewBolum.TabIndex = 110;
            // 
            // FakulteBolumPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtupdateNewBolum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDeleteBolumName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBolumName);
            this.Controls.Add(this.txtFakulteName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteFakulte);
            this.Controls.Add(this.txtUpdateBolum);
            this.Controls.Add(this.btnUpdatebolum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultFakulte);
            this.Controls.Add(this.btnCreateFakulte);
            this.Controls.Add(this.label6);
            this.Name = "FakulteBolumPenceresi";
            this.Size = new System.Drawing.Size(817, 537);
            this.Load += new System.EventHandler(this.FakulteBolumPenceresi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFakulteName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteFakulte;
        private System.Windows.Forms.TextBox txtUpdateBolum;
        private System.Windows.Forms.Button btnUpdatebolum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultFakulte;
        private System.Windows.Forms.Button btnCreateFakulte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBolumName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeleteBolumName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtupdateNewBolum;
    }
}
