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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        /*
         * SWITCH - CASE
         * IF-Else mantigiyle calisan bir kontrol mekanizmasidir. Aradaki fark, if-else yapisi buyukluk-kucukluk gibi durumlari kontrol ederken,
         * switch-case yalnizca esitlik durumlarini kontrol edebilen karar yapimizdir.. Kendisine ait bir index mekanizmasi ile kosullari algilar, 
         * siraya koyar ve otomatik olarak yuzlerce kosulunuz olsa bile herbirine bakmadan hangisine uydugunu bulabilir. Bu da performansı direktman etkiler...
         * Switch blogu icerisine yazdiginiz veri tipiniz ne ise, case (durum) olarak belirttiginiz tum veriler de ayni veri tipinde olmalıdır!
         * break => Kosul saglandi, artik karar yapisindan kendini disari atabilirsin mesajini sisteme verir...
         */
        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Disaridan mevsim girilsin, aylar donsun...

            string mevsim = txtDeger1.Text;
            string mesaj = "Mevsime ait ay isimleri : ";

            if (mevsim == "kış")
            {
                mesaj += "aralık - ocak - şubat";
            }
            else if (mevsim == "yaz")
            {
                mesaj += "haziran - temmuz - ağustos";
            }
            else if (mevsim == "sonbahar")
            {
                mesaj += "eylül - ekim - kasım";
            }
            else if (mevsim == "ilkbahar")
            {
                mesaj += "mart - nisan - mayıs";
            }
            else
            {
                mesaj = "aradığınız mevsime göre ay ismi bulunmamaktadır.";
            }

            MessageBox.Show(mesaj);
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            string mevsim = txtDeger1.Text;
            string mesaj = "Mevsime ait ay isimleri : ";

            switch (mevsim)
            {
                case "kış":
                    // kod blokları yer alacak
                    mesaj += "aralık - ocak - şubat";
                    break;
                case "yaz":
                    // kod blokları yer alacak
                    mesaj += "haziran - temmuz - ağustos";
                    break;
                case "ilkbahar":
                    mesaj += "mart - nisan - mayıs";
                    break;
                case "sonbahar":
                    mesaj += "eylül - ekim - kasım";
                    break;

                // else
                default:
                    mesaj = "aradığınız mevsime göre ay ismi bulunmamaktadır.";
                    break;
            }
            MessageBox.Show(mesaj);
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            // Kullanıcı dışarıdan ay adı girecek, uygulama o ayın, hangi mevsime ait olduğunu mb içerisinde (isteyen label'a yazdırsın) :)

            string ay = txtDeger1.Text.ToLower();
            string mesaj = "";
            //if (ay == "aralık")
            //{
            //    mesaj = "Kış";
            //}
            //else if (ay == "ocak")
            //{
            //    mesaj = "Kış";
            //}
            //else if (ay == "şubat")
            //{
            //    mesaj = "Kış";
            //}

            if (ay == "aralık" || ay == "ocak" || ay == "şubat")
                mesaj = "Kış";
            else if (ay == "mart" || ay == "nisan" || ay == "mayıs")
                mesaj = "İlkbahar";
            else if (ay == "haziran" || ay == "temmuz" || ay == "ağustos")
                mesaj = "Yaz";
            else if (ay == "eylül" || ay == "ekim" || ay == "kasım")
                mesaj = "Sonbahar";
            else
                mesaj = "Değer bulumadı";

            MessageBox.Show(mesaj);
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            string ay = txtDeger1.Text.ToLower();
            string mesaj = "";
            switch (ay)
            {
                case "aralık":
                case "ocak":
                case "şubat":
                    mesaj = "kış";
                    break;

                case "mart":
                case "nisan":
                case "mayıs":
                    mesaj = "ilkbahar";
                    break;

                case "haziran":
                case "temmuz":
                case "ağustos":
                    mesaj = "yaz";
                    break;

                case "eylül":
                case "ekim":
                case "kasım":
                    mesaj = "sonbahar";
                    break;

                default: mesaj = "Not Found (404)"; break;
            }
            MessageBox.Show(mesaj);
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            //İç içe switch kullanarak kullanıcı adını ve şifresini kontrol ediniz.eğer kullanıcı kullanıcıadını ve şifresini doğru girerse "Tebrikler, hem kullanıcı adı hemde şifreniz doğru" uyarısı
            //Kullanıcı adı doğru şifre yanlışsa "Kullanıcı adınız doğru ancak şifreniz yanlış!" uyarısı
            //kullanıcı adı yanlışsa "Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!" uyarusını kullanıcıya veriniz

            string userName = txtDeger1.Text;
            string password = txtDeger2.Text;

            if (userName == "admin")
            {
                if (password == "123")
                {
                    MessageBox.Show("Giriş Yaptınız!");
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adınız Doğru Fakat, Şifreniz Yanlış");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız Yanlış, Şifrenizi Kontrol Etmedim");
            }
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            string userName = txtDeger1.Text;
            string password = txtDeger2.Text;

            switch (userName)
            {
                case "admin":
                    switch (password)
                    {
                        case "123":
                            MessageBox.Show("Giriş Yaptınız!");
                            break;
                        default:
                            MessageBox.Show("Kullanıcı Adınız Doğru Fakat, Şifreniz Yanlış");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Kullanıcı Adınız Yanlış, Şifrenizi Kontrol Etmedim");
                    break;
            }
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            // C#7 ile gelen yeni özellikte artık küçüklük büyüklük, küçük eşit büyük eşit gibi tüm durumlarıda artık kontrol edebiliyoruz. 
            // NOT :  visual studio 2017'de ve üzeri kullanabiliyor. 2015 kullanılıyor ise, örnek çalışmaz 

            int not = 12;

            //if(not < 0) { }
            //else if(not > 100) { }
            //else { }

            switch (not)
            {
                case int s when (s < 0):
                    break; 
                case int s when (s > 100):
                    break;
                default:
                    break;
            }
        }
    }
}
