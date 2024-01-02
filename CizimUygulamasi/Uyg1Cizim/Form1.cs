using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg1Cizim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Cyan, 5f); //float old için f de
            cizimAlani.DrawLine(kalem, 50, 60, 100, 200);
            //ilki nesnemiz neyle çizcez ,2.ve 3. a(x,y) diyoz ya 3. ve 4. ise b(c,d) gibi düşün
            //yada ezberleme normal ( açinca neymiş vs çıkıyor visual stdui info veriyor
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Magenta, 2f);
            cizimAlani.DrawEllipse(kalem, 90, 70, 60, 60);
            //ne çizeceksen hepsi için ayrı ayrı panel alanı yapıyon 2 sindede aynı paneli seçtik pnael 1 mesela
            //sonra kalem nesnesi tantıon o kalemi kullanrak çizecen şeyi draw ve konumlarla yapıyon
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 2f);
            cizimAlani.DrawRectangle(kalem, 100, 50, 80, 70);

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {//fare ile tıklayarak oluşturma
            Graphics cizimAlani = panel2.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 2f);
            cizimAlani.DrawRectangle(kalem, e.X, e.Y, 50, 50);

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {//hareket ederek bu mousemove vs properties de eventslerden aççan çift tık ile
            label1.Text = e.X + "," + e.Y;
            Graphics cizimAlani = panel2.CreateGraphics();
            Pen kalem = new Pen(Color.Red, 4f);
            cizimAlani.DrawEllipse(kalem, e.X, e.Y, 5, 5);
        }

        int[] Xler = new int[3];
        int[] Yler = new int[3];
        int tiklamaSayisi = 0;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Xler[tiklamaSayisi] = e.X;
            Yler[tiklamaSayisi] = e.Y;
            tiklamaSayisi++;
            if (tiklamaSayisi == 3)
            {
                Graphics cizimAlani = panel1.CreateGraphics();
                Pen kalem = new Pen(Color.Indigo, 2f);
                cizimAlani.DrawLine(kalem, Xler[0], Yler[0], Xler[1], Yler[1]);
                cizimAlani.DrawLine(kalem, Xler[1], Yler[1], Xler[2], Yler[2]);
                cizimAlani.DrawLine(kalem, Xler[2], Yler[2], Xler[0], Yler[0]);
                tiklamaSayisi = 0; //bunu sıfırlamazsak sadece 1 üçgen çizer


            }
        }

        int[] Xler2 = new int[2];
        int[] Yler2 = new int[2];
        int Ts2 = 0;
        //ts tıklama sayısıdır
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Xler2[Ts2] = e.X;
            Yler2[Ts2] = e.Y;
            Ts2++;
            if (Ts2 == 2)
            {
                //ciz
                Graphics cizimAlani = panel3.CreateGraphics();
                Pen kalem = new Pen(Color.Maroon, 2f);
                cizimAlani.DrawLine(kalem, Xler2[0], Yler2[0], Xler2[1], Yler2[1]);
                Ts2 = 0;
            }
        }
    }
}
