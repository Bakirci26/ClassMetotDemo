using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+" "+musteri.Surname+""+"adlı kişi eklendi");
        }
        
        public void Sıl(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + "" + "adlı kişi silindi");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " "+musteri.Surname+ " müşteri bilgileri getirildi.");
        }

    }
}
