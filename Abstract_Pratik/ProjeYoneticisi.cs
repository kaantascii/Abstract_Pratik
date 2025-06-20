using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Pratik
{
    class ProjeYoneticisi : Calisan
    {
        // Constructor (Yapıcı Metot)
        public ProjeYoneticisi(string ad, string soyad,string departman) 
            : base(ad, soyad, departman)
        {
        }
        // Override: Abstract sınıfın abstract metodunu implement(tanımlamak) ediyoruz.
        public override void Gorev()
        {
            Console.WriteLine($"Proje Yöneticisi: {Ad} {Soyad}, Departman: {Departman} \n Proje yöneticisi olarak çalışıyorum.");
        }
    }
}
