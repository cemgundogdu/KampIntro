using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.fiyati = 15;
            urun1.aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.fiyati = 80;
            urun2.aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            // type safe --- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("----------Metotlar----------");
            //instance -- örnek
            //encapsulation -- kapsülleme

            SepetManager sepetManager = new SepetManager(); 
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil-sarı", 12,10);
            sepetManager.Ekle2("elma", "yeşil elma", 12,9);
            sepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 12,8);




        }
    }
}



