using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety --> tip güvenliği
            // Do not repeat yourself
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool SistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }




            if (SistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        


        }
    }
}
