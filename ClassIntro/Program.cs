using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Cem";
            int yas = 36;
            kurs kurs1= new kurs() ;
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "phyton";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi +" " + kurs1.Egitmen);

            kurs[] kurslar = new kurs[] { kurs1,kurs2,kurs3 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


            
        }

        class kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }


}
