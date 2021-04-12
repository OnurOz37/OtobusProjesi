using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Otobus Otogar;
       

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                Otogar = new Otobus(textBox1.Text, Convert.ToInt32(textBox2.Text));
                
                label3.Text = "Otobus numarasi olusturuldu, OtobusNo: " + textBox1.Text+ " "+ "Koltuk sayisi: "  +Otogar.BosKoltukOgren();
                label3.ForeColor = Color.Black;

            }
            catch
            {
                label3.Text = "Otobus numarasi olusturulamadi, girilen bilgileri tekrar kontrol ediniz";
                label3.ForeColor= Color.Red;
                MessageBox.Show("Duzgun gir Uleynnnn");
            }
            /* Olustur butonuna yazdığımız kodlarla Otobus sınıfı üzerinden Otogar isimli bir nesne oluşturuyoruz
             * olustur butonuna basıldığında textbox kontrollerine girilen değerler parametre olarak gönderilerek kurucu metod, yani Otobus sinifindaki public otobusun çalışması saglaniyo
             * label3ten de kullaniciya bilgi veriyoruz
            
            */
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Otogar.BiletSat(cb1.Checked);
            label3.Text = "Bilet satildi, Kalan koltuk sayisi : " + Otogar.BosKoltukOgren(); //sinifimizdaki metodlari cagirip calistiriyoruz
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Otogar.BiletIptal(cb1.Checked);
            label3.Text = "Bilet iptal edildi, Kalan koltuk sayisi : " + Otogar.BosKoltukOgren();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            label3.Text = "Bakiye : " + Otogar.BakiyeOgren() + "€";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            label3.Text = "Bos koltuk sayisi : " + Otogar.BosKoltukOgren(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Otogar.OgrenciyeSat(checkBox1.Checked);
            label3.Text = "Bilet ogrenci tarifesine gore satildi, lutfen gisede ogrenci kartinizi gosteriniz \nKalan koltuk sayisi: " + Otogar.BosKoltukOgren();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otogar.OgrenciIptal(checkBox1.Checked);
            label3.Text = "Bilet ogrenci tarifesine gore iptal edildi, Kalan koltuk sayisi: " + Otogar.BosKoltukOgren(); 
        }
    }

}
