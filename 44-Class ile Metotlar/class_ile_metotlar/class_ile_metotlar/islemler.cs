using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ile_metotlar
{
    class islemler
    {
        //Topla Metodu
        public int topla(int a,int b)
        {
            return a + b;
        }

        //Çıkar Metodu
        public int cikar(int a,int b)
        {
            return a - b;
        }

        //Çarp Metodu
        public int carp(int a,int b)
        {
            return a * b;
        }

        //Böl Metodu
        public double bol(double a,double b)
        {
            return a / b;
        }

        // faktoriyel
        public int faktoriyel(int a)
        {
            int sonuc = 1;
            for (int i = 1; i <=a; i++)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }
    }
}
