using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 05;
            musteri1.Name = "Mustafa";
            musteri1.Surname = "Bakırcı";



            Musteri musteri2 = new Musteri();
            musteri2.ID = 06;
            musteri2.Name = "Berna";
            musteri2.Surname = "Bakırcı";



            Musteri musteri3 = new Musteri();
            musteri3.ID = 07;
            musteri3.Name = "Rana";
            musteri3.Surname = "Bakırcı";


            Musteri[] musteriler = new Musteri[]{musteri1,musteri2,musteri3};

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.ID);
                Console.WriteLine(musteri.Name);
                Console.WriteLine(musteri.Surname);

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sıl(musteri3);
            musteriManager.Listele(musteri2);
        
        }
    }
}
