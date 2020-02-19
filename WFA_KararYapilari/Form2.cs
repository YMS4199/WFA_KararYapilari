using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KararYapilari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /*
              * MANTIKSAL OPERATORLER
              * Birden fazla durumun ayni anda kontrol edilmesi senaryosunda kullanilan operatorlerdir...
              * && (VE) (Kontrol blogu icerisinde yer alan tum kosullarin saglanmasi durumuna isaret   eder...             Kosullardan  biri dahi saglanmazsa blogunuz harekete gecmez...)
              * || (VEYA) (Kontrol blogu icerisinde yer alan kosullardan herhangi birinin saglanmasi    durumuna        isaret      eder... Boylece bir kosul bile saglansa blogunuza yazdiginiz    kodlar  harekete     gecer...)   Kısayol  =>   ALTGR   + Tire
              * 
              * Yukarıdaki operatorlere "kısa devre operatoru (shortcut operator)" adi verilir.. Kosullari          kontrole    en    soldan baslar, herhangi bir uygunsuzluk durumunda diger  kosullara   asla      bakmaz!..  Asagidaki      operatorlerde  ise, kosullar uysun ya da  uymasin hepsi   kontrol      edilir...
              * 
              * & => VE
              * | => VEYA
              */


        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //if (txtDeger1.Text == "admin")
            //{ 
            //    if (txtDeger2.Text == "123")
            //    {
            //        MessageBox.Show("Giriş Yaptınız!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Şifreniz Yanlış!");

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı Adınız Yanlış");
            //}

            if (txtDeger1.Text == "admin" && txtDeger2.Text == "123")
            {
                MessageBox.Show("Giriş Yaptınız");
            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileriniz Yanlış");
            }

            // &&  => shift + 6
            // ||  => AltGr + - (tire)
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Girilen not 0 - 30 araligi ise "FF" 30 - 50 araligi "DD" 50 - 70 "BB" 70 - 100 "AA" aldınız seklinde kullaniciyi uyariniz..
        }

        private void btnOrnek2_2_Click(object sender, EventArgs e)
        {

        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!
            // Kullanıcı alanı boş geçerse, lütfen bir ürün adı giriniz uyarısı verdiriniz.
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {

            // Disaridan siparis alinacak olan kitap miktari girilsin. Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10, 50-100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin. Kitabın birim fiyatı => 5 TLdir... Amac => Odenecek tutari kullaniciya gostermek...

            /*
             Sipariş Edilen Kitap Sayısı       : 120 adet
             Ödemeniz Gereken İndirimsiz Tutar : 600 TL
             Uygulanan İndirim Oranı           : %25
             Toplam Ödemeniz Gereken Tutar     : 450 TL
             */
        }
    }
}
