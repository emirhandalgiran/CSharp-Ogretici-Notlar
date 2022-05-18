using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarinAsiriYuklenmesi
{
    class islemler
    {
        public int hesapla(int sinav1,int sinav2,int performans)
        {
            return (sinav1 + sinav2 + performans) / 3;
        }

        public int hesapla(int sinav1,int sinav2,int performans,int proje)
        {
            return (sinav1 + sinav2 + performans + proje) / 4;
        }
    }
}
