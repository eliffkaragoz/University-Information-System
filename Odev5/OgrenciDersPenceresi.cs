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
    public partial class OgrenciDersPenceresi : UserControl
    {

        
        public OgrenciDersPenceresi()
        {
            InitializeComponent();
           
        }

        private void OgrenciDersPenceresi_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateOgrenciDers_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {

                Ogrenci _ogrenci = ctx.Ogrencis.Where(x => x.ogrenciAd == txtOgrenciName.Text).SingleOrDefault();
                Ders _ders = ctx.Derss.Where(x => x.dersAd == txtDersName.Text).SingleOrDefault();
                OgrenciDers ogrDers = new OgrenciDers()
                {
                    yariyil = Convert.ToInt32( txtYarıyıl.Text),
                    vize = Convert.ToInt32(txtVize.Text),
                    final = Convert.ToInt32(txtFinal.Text),
                    yil = Convert.ToInt32(txtYil.Text),
                    Ders = _ders,
                    Ogrenci = _ogrenci


                };
                ctx.OgrenciDerss.Add(ogrDers);

                ctx.SaveChanges();
                lblResultOgrenciDers.Text = "OGRENCİ DERS Added";

            }
        }

        private void lblResultOgrenciDers_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOgrenciDers_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
