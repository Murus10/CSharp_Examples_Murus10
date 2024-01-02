using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg2Dialoglar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult basilan = MessageBox.Show("Bu bir mesaj kutusudur", "Başlık", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (basilan == DialogResult.Yes)
                MessageBox.Show("Yese bastiniz");
            // message box 4 parametrreli aslında  MessageBox.Show("Yese bastiniz","başlık buda ", MessageBoxButtons. vs durdur yeniden dene tamam vs,Message.BoxIcon.errror vs ikon simge buda );
            else if (basilan == DialogResult.No)
                MessageBox.Show("Noya bastiniz");
            else
                MessageBox.Show("Cancela bastiniz");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Metin Dosyaları|*.txt;*.doc;*.docx";
            DialogResult basilan = od.ShowDialog();
            //Show dialog KESİN YAP gösterilmesi için, bunu toolbaxdan diaglogdan da ekleyebilrdin aşağıda gösterir ama
            if (basilan == DialogResult.OK)
            {
                //secilen dosyayi al
                string secilen = od.FileName;
                // richTextBox1.LoadFile(secilen, RichTextBoxStreamType.PlainText);
                System.IO.StreamReader on = new System.IO.StreamReader(secilen);
                string icerik = on.ReadToEnd();
                richTextBox1.Text = icerik;
                on.Close();

                //richtextboxta görüntüle
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Metin Dosyaları|*.txt;*.pdf"; //arada ; ile birdden f
            sd.DefaultExt = ".txt";
            DialogResult basilan = sd.ShowDialog();
            if (basilan == DialogResult.OK)
            {
                string kaydedilecek = sd.FileName;
                //richTextBox1.SaveFile(kaydedilecek,RichTextBoxStreamType.PlainText);
                System.IO.StreamWriter yn = new System.IO.StreamWriter(kaydedilecek, false);
                yn.WriteLine(richTextBox1.Text);
                yn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult basilan = fd.ShowDialog();
            if (basilan == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult basilan = cd.ShowDialog();
            if (basilan == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Resim Dosyaları|*.jpeg;*.png;";
            DialogResult basilan = od.ShowDialog();

            if (basilan == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(od.FileName);

            }


        } //hoca resim ekle şeyinide yaptı onabak son 5dk da
    }
    }
