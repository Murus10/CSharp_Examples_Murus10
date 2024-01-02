using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg3VKI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int agirlik = Convert.ToInt32(numericUpDown1.Value);
            double boy = Convert.ToDouble(textBox1.Text) / 100;
            double vki = agirlik / (boy * boy);
            label4.Text = "VKI:" + vki;

            int altsinir;
            int ustsinir;
            if(radioButton1.Checked==true)
            {
                ustsinir = 25;
                altsinir = 20;
            }
            else
            {
                 altsinir = 19;
                 ustsinir = 24;

            }

            if (vki < altsinir)
                label5.Text = "VKI düşük, kilo almalisiniz";
            else if (vki > ustsinir)
                label5.Text = "VKI yuksek, kilo vermelisiniz";
            else
                label5.Text = "İdeal kilodasiniz";
        }
    }
}
