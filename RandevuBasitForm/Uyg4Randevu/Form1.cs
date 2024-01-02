using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg4Randevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tckno = textBox1.Text;
            string adi = textBox2.Text;
            string soyadi = textBox3.Text;
            string klinik=comboBox1.SelectedItem.ToString();
            string tarih = dateTimePicker1.Value.ToShortDateString();
            //tostring deseydi saat bilgiside gelirdi toshortdate dedii için sadece tarih geldi
            string saat = comboBox2.SelectedItem.ToString();
            //to sting şöyle nesnemiz objecft old için stringe çeviriyoz
            //string satir = tckno + " " + adi + " " + soyadi + " " + klinik + " " + tarih + " " + saat + Environment.NewLine; //ENVİPMENT /n ile aynı alt satıra geçmme komutu
             //textBox4.Text += satir;
            //BURASI TEXTE YAZDIRMA
            if (Randevu.varMi(klinik, tarih, saat) == false)
            {
                Randevu.Ekle(tckno, adi, soyadi, klinik, tarih, saat);
                //BURASI İSE DOSYAYA YAZDIRMA
                MessageBox.Show("Eklendi");
                temizle();
            }
            else
              //buraları try catch ile de yapabilirsin
                MessageBox.Show("Seçilen kliniğe seçilen tarih ve saatte zaten randevu var");
        }

        public void temizle()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            comboBox2.SelectedIndex = -1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string icerik = Randevu.tumRandevular();
            textBox4.Text = icerik;
        }
    }
}
