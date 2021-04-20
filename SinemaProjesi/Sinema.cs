using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaProjesi
{
    public class Sinema
    {

        int ToplamKoltukSayisi;
        string SalonNo;
        double Ciro;
        int BosKoltukSayisi;

        const double NormalTarife = 20;
        const double Indirimli = 15;
        const double Ogrenci = 12;
        const double Cocuk = 8; 

        public Sinema(string Salon, int koltuksayisi)
        {
            ToplamKoltukSayisi = koltuksayisi;
            SalonNo = Salon;
            BosKoltukSayisi = ToplamKoltukSayisi;
            Ciro = 0; 
           

        }
        public void Sat(bool indirimli)
        {
            BosKoltukSayisi--;
            if (indirimli)

                Ciro += Indirimli;
            else
                Ciro += NormalTarife;


            

        }
        public void IptalEt(bool indirimli)
        {
            BosKoltukSayisi++;
            if (indirimli)
                Ciro -= Indirimli;
            else
                Ciro -= NormalTarife;

        }

        public void OgrenciyeSat(bool ogrenci)
        {
            BosKoltukSayisi--;
            if (ogrenci)
                Ciro += Ogrenci;
            else
                Ciro += Ogrenci;

        }
        public void OgrenciIptalEt(bool ogrenci)
        {
            BosKoltukSayisi++;
            if (ogrenci)
                Ciro -= Ogrenci;
            else
                Ciro -= Ogrenci;
        }
        public void CocukTarife (bool cocuk)
        {
            BosKoltukSayisi--;
            if (cocuk)
                Ciro += Cocuk;
            else
                Ciro += Cocuk;
        }
        public void CocukIptalEt (bool cocuk)
        {
            BosKoltukSayisi++;
            if (cocuk)
                Ciro -= Cocuk;
            else
                Ciro -= Cocuk;

        }
        public int BoskoltukOgren ()
        {
            return BosKoltukSayisi;

        }
        public double CiroyuOgren()
        {
            return Ciro; 

        }
    }
}
