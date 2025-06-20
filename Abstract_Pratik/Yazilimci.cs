using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Pratik
{
     class Yazilimci : Calisan
    {
        //Constructor (Yapıcı Metot)
        public Yazilimci(string ad, string soyad, string departman) : base(ad, soyad, departman)
        {
        }
        //Override: Abstract sınıfın abstract metodunu implement(tanımlamak) ediyoruz.
        public override void Gorev()
        {
            Console.WriteLine($"Yazılım Geliştirici : {Ad} {Soyad}, Departman: {Departman} \n Yazılım geliştirici olarak çalışıyorum.");
        }

    }
}
