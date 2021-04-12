using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusProjesi
{
    public class Otobus
    {

        int ToplamKoltukSayisi;
        int BosKoltukSayisi;
        double Bakiye;
        string otobusNo;

        const double Full = 15.0;
        const double Indirimli = 10.0;
        const double Ogrenci = 8.0; 
        //ornek icin gerekli ozellikleri olusturduk


        public Otobus(string bus, int koltuksayi)//2 parametre, kurucu metod
        {
            otobusNo = bus;
            ToplamKoltukSayisi = koltuksayi;
            BosKoltukSayisi = ToplamKoltukSayisi;
            Bakiye = 0;

            
        }
        public void BiletSat(bool indirimli)
        {
            BosKoltukSayisi--;
            if (indirimli)
                Bakiye += Indirimli;
            else
                Bakiye += Full;
            /* 
             *  bilet satışı gerçekleştiğinde boş koltuk sayısının azaltılması sağlanıyor. 
             *  ayrıca indirimli veya tam bilet olması durumuna göre bakiyenin arttırılması sağlanıyor.
             * */



        }
        public void BiletIptal(bool indirimli)
        {
            BosKoltukSayisi++;
            if (indirimli)
                Bakiye -= Indirimli;
            else
                Bakiye -= Full;

            /*
             Bu metodumuzda yine bool tipinde bir parametre alacak. 
            Gelen parametre ile biletin indirimli ya da tam bilet olduğunun kontrolünü yapacağız. 
            Para iadesi olacağı için bakiye azaltılacak ve boş koltuk sayısının arttırılması sağlanacak.
            */
        }
        public void OgrenciyeSat(bool ogrenci)
        {
            BosKoltukSayisi--;
            if (ogrenci)
                Bakiye += Ogrenci;
            else
                Bakiye += Ogrenci;

        }
        public void OgrenciIptal (bool ogrenci)
        {
            BosKoltukSayisi++;
            if (ogrenci)
                Bakiye -= Ogrenci;
            else
                Bakiye -= Ogrenci; 

        }
        public int BosKoltukOgren()
        {
            return BosKoltukSayisi;
            /* 
             * Burada sadece boş koltuk sayısının geri döndürüldüğünü görmekteyiz.
             */
        }
        public double BakiyeOgren()
        {
            return Bakiye;
            //geriye bakiye bilgisini double olarak döndürecektir.
        }
        



    }


}
