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
    public partial class FakulteBolumPenceresi : UserControl
    {
        public FakulteBolumPenceresi()
        {
            InitializeComponent();
        }

        private void FakulteBolumPenceresi_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateFakulte_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {
                Fakulte fakulte = ctx.Fakultes.Where(x => x.fakulteAd == txtFakulteName.Text).SingleOrDefault();  
                fakulte.Bolums.Add(
                    new Bolum
                    {
                        bolumAd = txtBolumName.Text
                       
                    });
                ctx.SaveChanges();
                lblResultFakulte.Text = "Students Added";
            }
        }
        private void btnUpdateBolum_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {
                var bolum = ctx.Bolums.SingleOrDefault(blm => blm.bolumAd.Equals(txtUpdateBolum.Text));
                if (bolum != null)
                {
                    bolum.bolumAd = txtupdateNewBolum.Text;
                    ctx.SaveChanges();
                    lblResultFakulte.Text = "Updated";
                }
            }
        }

        private void btnDeleteFakulte_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {
                ctx.Bolums.Remove(ctx.Bolums.SingleOrDefault(bolum => bolum.bolumAd.Equals(txtDeleteBolumName.Text)));
                ctx.SaveChanges();
                lblResultFakulte.Text = "Deleted";

            }
        }

        private void txtDeleteBolumName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFakulteName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBolumName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
