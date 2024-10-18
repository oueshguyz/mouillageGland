using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace projet1
{
    public partial class Form2 : Form
    {
        private SoundPlayer soundplayer = new SoundPlayer();
        public Form2()
        {
            this.CenterToScreen();
            InitializeComponent();
            soundplayer = new SoundPlayer(@"C:\Users\Nicolas\Desktop\robinet.wav");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (timer1.Enabled)
            {
                soundplayer.Play();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 75)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Séance terminée");
                this.Close();
                soundplayer.Stop();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("IL NE FAUT PAS INTERROMPRE LE MOUILLAGE GLAND 🚰");
            if (timer1.Enabled==false)
            {
                e.Cancel=false;
            }
        }
    }
}
