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
    public partial class HocaPenceresi : UserControl
    {
        public HocaPenceresi()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            using (var ctx = new Context())
            {
                Hoca hoca = new Hoca()
                {
                    ad = txtHocaAd.Text,
                    soyad = txtHocaSoyad.Text,
                };
                ctx.Hocas.Add(hoca);
                ctx.SaveChanges();
                lblResultOgrenci.Text = "Hoca Eklendi";
            }
               
        }

      

        private void btnUpdateHoca_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {
                var hoca = ctx.Hocas.SingleOrDefault(hc => hc.ad.Equals(txtUpdateHocaName.Text));
                if (hoca != null)
                {
                    hoca.ad = txtNewHocaName.Text;
                    hoca.soyad = txtNewOHocaSurname.Text;
                    ctx.SaveChanges();
                    lblResultOgrenci.Text = "Updated";

                }

            }
        }

        private void HocaPenceresi_Load(object sender, EventArgs e)
        {

        }
    }
}
