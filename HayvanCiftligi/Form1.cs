using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;



namespace HayvanCiftligi
{

    public partial class Form1 : Form
    {
        public int kasa = 0;
        public int sure = 0;
        Timer zamanlayici;
        Tavuk tavuk = new Tavuk();
        Ordek ordek = new Ordek();
        Inek inek = new Inek();
        Keci keci = new Keci();
        SoundPlayer inekses = new SoundPlayer();
        SoundPlayer tavukses = new SoundPlayer();
        SoundPlayer kecises = new SoundPlayer();
        SoundPlayer ordekses = new SoundPlayer();
        
        public Form1()
        {
            InitializeComponent();
            Text = "HayvanCiftligi";
            
            zamanlayici = new Timer();
            zamanlayici.Interval = 1000;
            zamanlayici.Tick += Zamanlayici_Tick;
            zamanlayici.Start();
            inekses.SoundLocation = "inek.wav";
            tavukses.SoundLocation = "tavuk.wav";
            ordekses.SoundLocation = "ordek.wav";
            kecises.SoundLocation = "keci.wav";

        }

        private void Zamanlayici_Tick(object sender, EventArgs e)
        {
            sure += 1;
            label7.Text = sure.ToString() + " SN";
            progressBar1.Value = tavuk.eNerji;
            tavuk.Enerji();
            if (sure % 3 == 0)
            {
                tavuk.Urun();
                label9.Text = Convert.ToString(tavuk.urun)+" ADET";
            }
            if (progressBar1.Value == 0)
            {
                label17.Text = "ÖLÜ";
                if (tavuk.yasam)
                    tavukses.Play();
                tavuk.yasam = false;
            }

            progressBar2.Value = ordek.eNerji;
            ordek.Enerji();
            if (sure % 5 == 0)
            {
                ordek.Urun();
                label11.Text = Convert.ToString(ordek.urun) + " ADET";
            }
            if (progressBar2.Value == 0)
            {
                label19.Text = "ÖLÜ";
                if (ordek.yasam)
                    ordekses.Play();
                ordek.yasam = false;
            }

            progressBar3.Value = keci.eNerji;
            keci.Enerji();
            if (sure % 7 == 0)
            {
                keci.Urun();
                label12.Text = Convert.ToString(keci.urun) + " KG";
            }
            if (progressBar3.Value == 0)
            {
                label20.Text = "ÖLÜ";
                if (keci.yasam)
                    kecises.Play();
                keci.yasam = false;
            }

            progressBar4.Value = inek.eNerji;
            inek.Enerji();
            if (inek.eNerji > 0)
            {
                if (sure % 8 == 0)
                {
                    inek.Urun();
                    label10.Text = Convert.ToString(inek.urun) + " KG";
                }
            }
            if (progressBar4.Value == 0)
            {
                label18.Text = "ÖLÜ";
                if (inek.yasam)
                    inekses.Play();
                inek.yasam = false;
            }
            if(inek.yasam==false&&tavuk.yasam==false&&keci.yasam==false&&ordek.yasam==false)
            {
                zamanlayici.Stop();
                MessageBox.Show("OYUN BİTTİ!!!");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ordek.YemVer();
            progressBar2.Value = ordek.eNerji;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tavuk.YemVer();
            progressBar1.Value = tavuk.eNerji;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inek.YemVer();
            progressBar4.Value = inek.eNerji;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            keci.YemVer();
            progressBar3.Value = keci.eNerji;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kasa = kasa + tavuk.urun;
            label8.Text = Convert.ToString(kasa)+" TL";
            tavuk.urun = 0;
            label9.Text = "0 ADET";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kasa = kasa + (ordek.urun*3);
            label8.Text = Convert.ToString(kasa)+" TL";
            ordek.urun = 0;
            label11.Text = "0 ADET";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kasa = kasa + (inek.urun * 5);
            label8.Text = Convert.ToString(kasa)+" TL";
            inek.urun = 0;
            label10.Text = "0 ADET";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kasa = kasa + (keci.urun * 8);
            label8.Text = Convert.ToString(kasa)+" TL";
            keci.urun = 0;
            label12.Text = "0 ADET";
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
