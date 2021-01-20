using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array --> dizi
            string kurs1 = "Yazılım geliştirici kursu";
            string kurs2 = "Programlamaya giriş";
            string kurs3 = "java";
            string kurs4 = "phyton";
            string kurs5 = "c#";
            string[] kurslar = new string[] { "Yazılım geliştirici kursu", "Programlamaya giriş", "java","phyton","c#" };






            for (int i = 0; i <kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Sayfa sonu - footer");


            foreach (string kurs in kurslar)  //kursları dolaş
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
