using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg2Yas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //proporties den eventlerden valuechanged e çift tıkladık
            // direk proportiesden max min value ile hangi tarih aralarıdnda olacagı vs ayarakayailrisn
            //date time picker value deger alır ondan .value yaptık
            //kullanicinin sectigi tarihi al
            DateTime dt = dateTimePicker1.Value;

            //sistemden o günün tarih bilgisini al
            DateTime oGun = DateTime.Now;
            //yillar arasi farktan yasi hesapla
            int yas = oGun.Year - dt.Year;
            //label 2 ye yas degerini ata
            label2.Text = "Yaşınız:" + yas.ToString();
        }
    }
}
