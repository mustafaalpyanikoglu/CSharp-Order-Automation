using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonSistemi
{
    public partial class KayıtEkranı : Form
    {
        public KayıtEkranı()
        {
            InitializeComponent();
        }
        Form1 grsEkrani;

        private void textBox2_Click(object sender, EventArgs e)//şifre
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grsEkrani = new Form1();
            timer1.Start();
            grsEkrani.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            grsEkrani.Left += 10;
            if (grsEkrani.Left >= 1000)
            {
                timer1.Stop();
                this.TopMost = false;
                grsEkrani.TopMost = true;
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            grsEkrani.Left -= 10;
            if (grsEkrani.Left <= 760)
            {
                timer2.Stop();
            }
        }

        private void KayıtEkranı_Load(object sender, EventArgs e)
        {
            //grsEkrani.Show();
        }
    }
}

