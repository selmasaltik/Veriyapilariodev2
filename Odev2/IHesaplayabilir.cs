using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public interface IHesaplayabilir
    {
        //aşağıdaki işlemleri iki kuyruk türü için de hesaplayacağımızdan metotlar ortak olur. Bu nedenle
        //ortak metotları interfacede tutabiliriz.
        int IslemTamamlama_suresi(int sure);
        double Ortalama_sure();
       

    }
}
