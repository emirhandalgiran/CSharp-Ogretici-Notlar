using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    class kapsul
    {
        int yas;
        //yas değişkeni için prperty tanımlandı
        public int Yas
        {
            get { return yas; }//okumak için kullanılır
            set {//yazdırmak için kullanılır
                if (value < 0)
                {
                    yas = 0;
                }
                else if (value>120)
                {
                    yas = 120;
                }
                else
                {
                    yas = value;//sistemden gelen veriyi gönder
                }
            
            }
        }
        
    }
}
