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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fakulteBolumPenceresi1.Hide();
            dersPenceresi1.Hide();
            ogrenciPenecersi1.Hide();
            ogrenciDersPenceresi1.Hide();
            listelemePenceresi1.Hide();
            ogrencilerinListelenmesi1.Hide();
            hocaPenceresi1.Hide();
            
        }

        private void btnFakulte_Click(object sender, EventArgs e)
        {
            
            dersPenceresi1.Hide();
            ogrenciPenecersi1.Hide();
            ogrenciDersPenceresi1.Hide();
            listelemePenceresi1.Hide();
            ogrencilerinListelenmesi1.Hide();
            hocaPenceresi1.Hide();

            fakulteBolumPenceresi1.Show();
            fakulteBolumPenceresi1.BringToFront();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            ogrenciPenecersi1.Hide();
            fakulteBolumPenceresi1.Hide();
            ogrenciDersPenceresi1.Hide();
            listelemePenceresi1.Hide();
            ogrencilerinListelenmesi1.Hide();
            hocaPenceresi1.Hide();


            dersPenceresi1.Show();
            dersPenceresi1.BringToFront();
        }
        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            fakulteBolumPenceresi1.Hide();
            ogrenciDersPenceresi1.Hide();
            listelemePenceresi1.Hide();
            ogrencilerinListelenmesi1.Hide();
            hocaPenceresi1.Hide();

            dersPenceresi1.Hide();
            ogrenciPenecersi1.Show();
            ogrenciPenecersi1.BringToFront();
        }

        private void btnOgrenciDers_Click(object sender, EventArgs e)
        {
            listelemePenceresi1.Hide();

            fakulteBolumPenceresi1.Hide();
            ogrencilerinListelenmesi1.Hide();
            hocaPenceresi1.Hide();

            dersPenceresi1.Hide();
            ogrenciPenecersi1.Hide();
            ogrenciDersPenceresi1.Show();
            ogrenciDersPenceresi1.BringToFront();
        }
        private void btnListeleme_Click(object sender, EventArgs e)
        {
            ogrencilerinListelenmesi1.Hide();
            fakulteBolumPenceresi1.Hide();

            hocaPenceresi1.Hide();

            dersPenceresi1.Hide();
            ogrenciPenecersi1.Hide();
            ogrenciDersPenceresi1.Hide();
            listelemePenceresi1.Show();
            listelemePenceresi1.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fakulteBolumPenceresi1.Hide();
            dersPenceresi1.Hide();
            ogrenciPenecersi1.Hide();
            ogrenciDersPenceresi1.Hide();
            listelemePenceresi1.Hide();
            hocaPenceresi1.Hide();

            ogrencilerinListelenmesi1.Show();


            ogrencilerinListelenmesi1.BringToFront();
        }
        private void btnHoca_Click(object sender, EventArgs e)
        {
            fakulteBolumPenceresi1.Hide();
            dersPenceresi1.Hide();
            ogrenciPenecersi1.Hide();
            ogrenciDersPenceresi1.Hide();
            listelemePenceresi1.Hide();
            ogrencilerinListelenmesi1.Hide();
            hocaPenceresi1.Show();
            hocaPenceresi1.BringToFront();
        }

        private void dersPenceresi1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void ogrenci_Penceresi1_Load(object sender, EventArgs e)
        {

        }

        private void ogrenciPenecersi1_Load(object sender, EventArgs e)
        {

        }

        private void ogrencilerinListelenmesi1_Load(object sender, EventArgs e)
        {

        }

       





        //private void ogrenciPenceresi1_Load(object sender, EventArgs e)
        //{

        //}


    }
}
