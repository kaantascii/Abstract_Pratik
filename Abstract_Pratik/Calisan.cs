using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Pratik
{
    abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        //Constructor (Yapıcı Metot)
        public Calisan(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }
        //Abstract Method: Alt sınıflar kendine göre implement(tanımlanmalıdır) etmelidir.
        public abstract void Gorev();
    }
}
