using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_4_1204045
{
    public partial class Form1 : Form
    {
        string kelas = "";
        string jadwal = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void biola_CheckedChanged(object sender, EventArgs e)
        {
            if (biola.Checked)
            {
                kelas = kelas + "Biola, ";
            }
        }

        private void gitar_CheckedChanged(object sender, EventArgs e)
        {
            if (gitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }
        }

        private void saxophone_CheckedChanged(object sender, EventArgs e)
        {
            if (saxophone.Checked)
            {
                kelas = kelas + "Saxophone, ";
            }
        }

        private void konduktor_CheckedChanged(object sender, EventArgs e)
        {
            if (konduktor.Checked)
            {
                kelas = kelas + "Konduktor, ";
            }
        }

        private void piano_CheckedChanged(object sender, EventArgs e)
        {
            if (piano.Checked)
            {
                kelas = kelas + "Piano, ";
            }
        }

        private void drum_CheckedChanged(object sender, EventArgs e)
        {
            if (drum.Checked)
            {
                kelas = kelas + "Drum, ";
            }
        }

        private void vokal_CheckedChanged(object sender, EventArgs e)
        {
            if (vokal.Checked)
            {
                kelas = kelas + "Vokal, ";
            }
        }

        private void komposer_CheckedChanged(object sender, EventArgs e)
        {
            if (komposer.Checked)
            {
                kelas = kelas + "Komposer, ";
            }
        }

        private void jadwal1_CheckedChanged(object sender, EventArgs e)
        {
            if (jadwal1.Checked)
            {
                jadwal = "Senin dan Rabu : 14.00 - 16.00";
            }
        }

        private void jadwal2_CheckedChanged(object sender, EventArgs e)
        {
            if (jadwal2.Checked)
            {
                jadwal = "Selasa dan Kamis : 14.00 - 16.00";
            }
        }

        private void jadwal3_CheckedChanged(object sender, EventArgs e)
        {
            if (jadwal3.Checked)
            {
                jadwal = "Sabtu dan Minggu : 09.00 - 11.00";
            }
        }

        private void jadwal4_CheckedChanged(object sender, EventArgs e)
        {
            if (jadwal4.Checked)
            {
                jadwal = "Minggu : 13.00 - 17.00";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nama : " + nama.Text + 
                "\nJenis Kelamin : " + jk.Text + 
                "\nTanggal Lahir : " + tgl.Text + 
                "\nPilihan Kelas : " + kelas +
                "\nPilihan Jadwal : " + jadwal,
                "Informasi Pendaftaran", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
               
        }
    }
}
