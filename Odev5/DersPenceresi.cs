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
    public partial class DersPenceresi : UserControl
    {
        public DersPenceresi()
        {
            InitializeComponent();
        }

        private void DersPenceresi_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateDers_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {

                Hoca hoca = ctx.Hocas.Where(x => x.ad == txtHoca.Text).SingleOrDefault();
                Ders ders = new Ders()
                {
                    dersAd = txtDersName.Text,
                 Hoca = hoca
                };
                ctx.Derss.Add(ders);
                ctx.SaveChanges();
                lblResultFakulte.Text = "Ders Eklendi";

            }
        }
       private void btnDeleteDers_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {
                ctx.Derss.Remove(ctx.Derss.SingleOrDefault(ders => ders.dersAd.Equals(txtDeleteDersName.Text)));
                ctx.SaveChanges();
                lblResultFakulte.Text = "Ders silindi!";
            }
        }
        private void btnUpdateDers_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {
                var ders = ctx.Derss.SingleOrDefault(drs => drs.dersAd.Equals(txtUpdateDers.Text));
                if (ders != null)
                {
                    ders.dersAd = txtNewDersName.Text;
                    ctx.SaveChanges();
                    lblResultFakulte.Text = "Updated";
                }



            }
        }

        private void txtUpdateDers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
