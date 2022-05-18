using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YapiciveYikiciMetotlar
{
    class sinifim
    {
        public sinifim()//constructor (yapıcı metot)
        {
            MessageBox.Show("sınıf çağırıldı");
        }
        ~sinifim()//destructor (yıkıcı metot)
        {
            MessageBox.Show("Sınıf sonlandırıldı");
        }

        public void mesaj()
        {
            MessageBox.Show("mesaj metodum çalıştı");

        }
    }
}
