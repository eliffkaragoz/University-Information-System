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
using System.Data.SqlClient;

namespace Odev5
{
    public partial class ListelemePenceresi : UserControl
    {
        public ListelemePenceresi()
        {
            InitializeComponent();
        }

        private void ListelemePenceresi_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            using (var ctx = new Context())
            {

                int ID = Convert.ToInt32(txtOgrenciName.Text);
                var result = from c in ctx.OgrenciDerss
                             where c.ogrenciID == ID
                             select c.Ders;
                dataGridView1.DataSource = result.ToList();
              

            }

        }
        private void btnListeleYil_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {

                int yil = Convert.ToInt32(txtYil.Text);
                int yariyil = Convert.ToInt32(txtYariyil.Text);
                var result = from c in ctx.OgrenciDerss
                             where c.yil == yil && c.yariyil == yariyil
                             select c.Ogrenci;
                dataGridView1.DataSource = result.ToList();


            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
