using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class productManager
    {
        public void add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi. ");
        }

        internal static void Add(object product, double v)
        {
            throw new NotImplementedException();
        }

        internal static void Add(Product product1)
        {
            throw new NotImplementedException();
        }


        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi. ");
        }

      public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }





    }



}
