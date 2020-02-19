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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*
          1) == Soldaki değerin, sağdaki değere eşit olma durumu
            1 == 1 => true  (if)
            1 == 2 => false (else)

          2) != Soldaki değerin, sağdaki değere eşit olmama durumu
            1 != 2 => true  (if)
            1 != 1 => false (else)

          3) >  Soldaki değerin, sağdaki değerden büyük olma durumu
            2 > 1  => true  (if)
            1 > 2  => false (else)

          4) <  Soldaki değerin, sağdaki değerden küçük olma durumu
            1 < 2  => true  (if)
            2 < 1  => false (else)

          5) >= Soldaki değerin, sağdaki değerden büyük veya eşit olma durumu
            1 >= 1 => true  (if) (eşitlik)
            2 >= 1 => true  (if) (büyük olma durumu)
            1 >= 2 => false (else)
            
          6) <= Soldaki değerin, sağdaki değerden küçük veye eşit olma durumu
            1 <= 2 => true  (if) (küçük olma durumu)
            1 <= 1 => true  (if) (eşit olma durumu)
            2 <= 1 => false (else)

          7) ! İşlem Sonucu  !(true) => false, !(false) => true

             
             */
        #region Örnek 1
        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            string username = txtDeger.Text;

            if (username == "admin")
            {
                MessageBox.Show("Hoşgeldiniz!");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
        }
        #endregion

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Eger girilen not 0'dan kucukse "O'dan küçük bir not girişi yapamazsınız" 100'den buyukse "100'den büyük bir not girişi yapamazsınız" mesajini gostersin...

            int not = int.Parse(txtDeger.Text);
            string mesaj = "";
            if (not < 0)
            {
                mesaj = "0'dan küçük not girişi yapamazsınız!";
            }
            else if (not > 100)
            {
                mesaj = "100'den büyük not girişi yapamazsınız!";
            }
            else
            {
                mesaj = "Notunuz : " + not;
            }
            MessageBox.Show(mesaj);

        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //textbox'ndan girilen sayi cift ise "Sayı Çifttir" tek ise "Sayı Tektir" mesajini kullaniciya gosteriniz... 
            int sayi = int.Parse(txtDeger.Text);
            if (sayi % 2 == 0)
            {
                MessageBox.Show("Sayı çifttir");
            }

            else
            {
                MessageBox.Show("Sayı tektir");
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Disaridan girilen kelimenin uzunlugu 8 karaktere esit ya da buyukse kayit onaylandi, degilse daha uzun bir sifre giriniz...


            int a = txtDeger.Text.Length;  // string
            int b = txtDeger.TextLength;   // TextBoxBase

            if(txtDeger.Text.Length >= 8)
            {
                MessageBox.Show("Tebrikler");
            }
            else
            {
                MessageBox.Show("Lütfen daha uzun bir şifre seçiniz!");
            }

        }
    }
}
