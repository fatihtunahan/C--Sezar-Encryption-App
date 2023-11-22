using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_Sifreleme_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anahtar;
            anahtar = Convert.ToInt32(textBox3.Text);
            string veri = "";
            veri = textBox1.Text;
            char[] karakterler = veri.ToCharArray();
            foreach(char eleman in karakterler)
            {
                textBox2.Text += Convert.ToChar(eleman + anahtar).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int anahtar;
            anahtar = Convert.ToInt32(textBox3.Text);
            string sifre = "";
            sifre = textBox2.Text;
            char[] karakterler2 = sifre.ToCharArray();
            foreach(char eleman2 in karakterler2)
            {
                textBox1.Text += Convert.ToChar(eleman2 - anahtar).ToString();
            }
        }
    }
}
