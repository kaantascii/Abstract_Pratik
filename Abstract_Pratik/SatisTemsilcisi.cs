using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Pratik
{
     class SatisTemsilcisi : Calisan
    {
        //Constructor (Yapıcı Metot)
        public SatisTemsilcisi(string ad, string soyad, string departman) : base(ad, soyad, departman)
        {
        }
        
        //Override: Abstract sınıfın abstract metodunu implement(tanımlamak) ediyoruz.
        public override void Gorev()
        {
            Console.WriteLine($"Satış Temsilcisi: {Ad} {Soyad}, Departman: {Departman} \n Satış temsilcisi olarak çalışıyorum.");

        }
    }
}
