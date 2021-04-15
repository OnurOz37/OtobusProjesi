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
                
                label3.Text = "Le numéro de Bus a été généré, busNo: " + textBox1.Text+ " "+ "Nombre de siège: "  +Otogar.BosKoltukOgren();
                label3.ForeColor = Color.Black;

            }
            catch
            {
                label3.Text = "Impossible de générer le numéro de bus, veuillez entrer les informations correctement sinon ca va facher";
                label3.ForeColor= Color.Red;
                MessageBox.Show("Tu fais quoi chacal");
            }
            /* Olustur butonuna yazdığımız kodlarla Otobus sınıfı üzerinden Otogar isimli bir nesne oluşturuyoruz
             * olustur butonuna basıldığında textbox kontrollerine girilen değerler parametre olarak gönderilerek kurucu metod, yani Otobus sinifindaki public otobusun çalışması saglaniyo
             * label3ten de kullaniciya bilgi veriyoruz
            
            */
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Otogar.BiletSat(cb1.Checked);
            label3.Text = "Billet vendu, siège restant : " + Otogar.BosKoltukOgren(); //sinifimizdaki metodlari cagirip calistiriyoruz
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Otogar.BiletIptal(cb1.Checked);
            label3.Text = "Billet annulé, siège restant : " + Otogar.BosKoltukOgren();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            label3.Text = "Gain : " + Otogar.BakiyeOgren() + "€";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            label3.Text = "Nombre de siège vide : " + Otogar.BosKoltukOgren(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Otogar.OgrenciyeSat(checkBox1.Checked);
            label3.Text = "Billet vendu au tarif étudiant, montre ta carte avant de monter a bord chacal \nSiège restant: " + Otogar.BosKoltukOgren();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otogar.OgrenciIptal(checkBox1.Checked);
            label3.Text = "Billet annulé chacal, siège restant: " + Otogar.BosKoltukOgren(); 
        }
    }

}
