using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_ForLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Foreach ile
        {
            string[] urunler = { "Kola", "Sarı Gazoz", "Ayran", "Soğuk Çay", "Gofret" };
            listBox1.Items.Clear();
            foreach (string liste in urunler)
            {
                listBox1.Items.Add(liste);
            }
        }

        private void button2_Click(object sender, EventArgs e) // For ile
        {
            string[] urunler = { "Kola", "Sarı Gazoz", "Ayran", "Soğuk Çay", "Gofret" };
            listBox2.Items.Clear();
            for (int i = 0; i < urunler.Length; i++)
            {
                listBox2.Items.Add(urunler[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e) // For ile tersten
        {
            string[] urunler = { "Kola", "Sarı Gazoz", "Ayran", "Soğuk Çay", "Gofret" };
            listBox3.Items.Clear();
            for (int i = urunler.Length - 1; i >= 0; i--)
            {
                listBox3.Items.Add(urunler[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string gun = "Pazartesi";
            char[] dizi = new char[gun.Length];
            int sayac = 0;
            listBox4.Items.Clear();
            for (int i = gun.Length - 1; i >= 0; i--)
            {
                dizi[sayac] = gun[i];
                sayac++;
                listBox4.Items.Add(gun[i]);
            }
            string diziden_gelen_deger = new string(dizi); // char dizisini yeni bir stringe çevirir.
            MessageBox.Show(diziden_gelen_deger);
        }
    }
}