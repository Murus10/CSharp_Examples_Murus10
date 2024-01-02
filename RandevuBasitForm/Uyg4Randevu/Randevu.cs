using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Uyg4Randevu
{
    class Randevu
    {

        static string dosyaYolu = @"randevu.txt";
        //@in amaci tek / koymak için c/ vs normalde c// yapman gerikiyor özel algılamamsı için
        //yol belirtmezsen direk yazarsan direk exe nin old yerde olsun dedik
        public static void Ekle(string tc, string a, string s, string k, string t, string saat)
        {

            StreamWriter yazmaNesnesi = new StreamWriter(dosyaYolu, true);
            //write:mevcut icerik silinir yeni korunur, yazmaModu:false
            //append: mevcut icerik korunur, yeni sonuna eklenir, yazmaModu:true
            string satir = tc +"*" +a +"*"+ s +"*"+ k +"*"+ t +"*"+ saat;
            //aralara yıldız koyma
            yazmaNesnesi.WriteLine(satir);
            yazmaNesnesi.Close();
            //her yazma nesnesini işin bitince kapat
        }

        public static string tumRandevular()
        {
            string icerik = "";
            StreamReader okumaNesnesi = new StreamReader(dosyaYolu);
            while (okumaNesnesi.EndOfStream == false)
            {
                icerik += okumaNesnesi.ReadLine()+Environment.NewLine;

            }
            okumaNesnesi.Close();
            return icerik;
        }

        public static bool varMi(string k, string t, string s)
        {
            bool sonuc = false;
            StreamReader okumaNesnesi = new StreamReader(dosyaYolu);
            while (okumaNesnesi.EndOfStream == false)
            {
                string satir = okumaNesnesi.ReadLine();
                string[] parcalar = satir.Split('*');
                
                if (parcalar[3] == k && parcalar[4] == t && parcalar[5] == s)
                    sonuc = true;
                //bura okuma kaydediyor pc gibi düşün peki neden 345 yani bolum tarih saat çnkü eşit olursa onlar eşit olur
                //isimi soyismi eşit diye randevu vermeme olmaz 
            }

            okumaNesnesi.Close();
            return sonuc;

        }
    }
}
