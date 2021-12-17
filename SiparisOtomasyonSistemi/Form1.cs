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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        KayıtEkranı kytEkrani = new KayıtEkranı();

        private void textBox3_Click(object sender, EventArgs e)//email
        {
            textBox3.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)//şifre
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kytEkrani.Left += 10;
            if(kytEkrani.Left>=1000)
            {
                timer1.Stop();
                this.TopMost = false;
                kytEkrani.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            kytEkrani.Left -= 10;
            if (kytEkrani.Left <=760)
            {
                timer2.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kytEkrani.Show();
        }

        

        
    }
}
