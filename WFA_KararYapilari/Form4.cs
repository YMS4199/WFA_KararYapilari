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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        bool Kaydet()
        {
            // Database'e kayıt eklenecek, işlem sonucu geriye dönecek

            int etkilenenSatirSayisi = 1; // db'den gelecek
            bool result = etkilenenSatirSayisi > 0;
            return result;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // Kaydetme metodu true değer dönüyorsa, 
            bool result = Kaydet();

            //if (result)
            //{
            //    MessageBox.Show("Kayıt Başarıyla Eklendi");
            //}
            //else
            //{
            //    MessageBox.Show("Kayıt Ekleme Hatası");
            //}


            //switch (result)
            //{
            //    case true:
            //        MessageBox.Show("Kayıt Başarıyla Eklendi");
            //        break;
            //    default:
            //        MessageBox.Show("Kayıt Ekleme Hatası");
            //        break;
            //}

            //MessageBox.Show(result ? "Kayıt Eklendi" : "Kayıt Ekleme Hatası");


            MessageBox.Show(10 > 0 ? "Kayıt Eklendi" : "Kayıt Ekleme Hatası");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text.Length > 0 ? textBox1.Text : "default değer");

            MessageBox.Show(!string.IsNullOrWhiteSpace(textBox1.Text) ? textBox1.Text : "default değer");
        }
    }
}
