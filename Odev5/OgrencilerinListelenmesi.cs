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
    public partial class OgrencilerinListelenmesi : UserControl
    {
        public OgrencilerinListelenmesi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OgrencilerinListelenmesi_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {

                int ID = Convert.ToInt32(txtDersNumber.Text);
                var result = from c in ctx.OgrenciDerss
                             where c.dersID == ID
                             select c;


                dataGridView1.DataSource = result.ToList();


            }
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}
