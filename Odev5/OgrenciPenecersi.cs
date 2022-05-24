using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev5
{
    public partial class OgrenciPenecersi : UserControl
    {


        public OgrenciPenecersi()
        {
            InitializeComponent();
            

        }

        private void OgrenciPenecersi_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateOgrenci_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {
                Bolum bolum = ctx.Bolums.Where(x => x.bolumAd == txtBolum.Text).SingleOrDefault();

                bolum.Ogrencis.Add(
                    new Ogrenci {
                        ogrenciAd = txtOgrenciName.Text,
                        ogrenciSoyad = txtOgrenciSoyad.Text, });
                ctx.SaveChanges();
                lblResultOgrenci.Text = "Orenci Eklendi cnmmmm ";}
        }

        private void btnDeleteOgrenci_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context()) {
                ctx.Ogrencis.Remove(ctx.Ogrencis.SingleOrDefault(stu => stu.ogrenciAd.Equals(txtDeleteOgrenciName.Text)));
                ctx.SaveChanges();
                lblResultOgrenci.Text = "Deleted";}
        }

        private void btnUpdateOgrenci_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {
                var student = ctx.Ogrencis.SingleOrDefault(ogrenci => ogrenci.ogrenciAd.Equals(txtUpdateOgrenci.Text));
                if (student != null)
                {
                    student.ogrenciAd = txtNewOgrenciName.Text;
                    student.ogrenciSoyad = txtNewOgrenciSurname.Text;
                    ctx.SaveChanges();
                    lblResultOgrenci.Text = "Updated";
                }

            }
       
        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBolumName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboBolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//22.05.2022 18:54:37