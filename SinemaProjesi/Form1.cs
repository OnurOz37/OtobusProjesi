using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaProjesi
{
    public partial class Form1 : Form
    {
        Sinema SinemaBiletSat;
        public Form1()
        {
            InitializeComponent();
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer2.Visible = false; 
            axWindowsMediaPlayer1.URL = "C:\\Users\\onur_\\Downloads\\bdt.mp3";
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn8Olustur_Click(object sender, EventArgs e)
        {
            try
            {
                SinemaBiletSat = new Sinema(textBox2.Text, Convert.ToInt32(textBox3.Text));

                lbl1.Text = "Bilet olusturuldu, Salon no: " + textBox1.Text + " Kalan koltuk sayisi :" + SinemaBiletSat.BoskoltukOgren() + "\nSeçilen film :" + comboBox1.SelectedItem;
                
            }
            catch
            {
                lbl1.Text = "Bilet olusturulamadi, lutfen bilgileri tekrar kontrol ediniz";
                
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SinemaBiletSat.Sat(checkBox1.Checked);
            lbl1.Text = "Bilet normal tarifede satildi, Kalan koltuk sayisi :" + SinemaBiletSat.BoskoltukOgren();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            SinemaBiletSat.IptalEt(checkBox1.Checked);
            lbl1.Text = "Bilet Iptal edildi, Kalan Koltuk sayisi :" + SinemaBiletSat.BoskoltukOgren();
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            SinemaBiletSat.OgrenciyeSat(checkBox2.Checked);
            lbl1.Text = "Bilet ogrenci tarifesine gore satildi, Kalan koltuk sayisi :" + SinemaBiletSat.BoskoltukOgren();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            SinemaBiletSat.OgrenciIptalEt(checkBox2.Checked);
            lbl1.Text = "Bilet ogrenci tarifesine gore iptal edildi, Kalan koltuk sayisi :" + SinemaBiletSat.BoskoltukOgren();
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                btn6.Enabled = true;
            else
                btn6.Enabled = false;


            SinemaBiletSat.CocukTarife(checkBox3.Checked);
            lbl1.Text = "Bilet cocuk tarifesine gore satildi, Kalan koltuk sayisi :" + SinemaBiletSat.BoskoltukOgren();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            SinemaBiletSat.CocukIptalEt(checkBox3.Checked);
            lbl1.Text = "Bilet cocuk tarifesine gore iptal edildi, Kalan koltuk sayisi :" + SinemaBiletSat.BoskoltukOgren();
            btn6.Enabled = true; 
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text =""+ SinemaBiletSat.CiroyuOgren()+ "TL"; 
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "C:\\Users\\onur_\\Downloads\\basliyor.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.stop(); 
        }
    }
}
