using Abstract_Pratik;

class Program
{
    static void Main(string[] args)
    {   // Abstract sınıfı örneklenemez, bu yüzden alt sınıflarını kullanıyoruz.
        Calisan h = new ProjeYoneticisi("Hasan", "Çıldırmış", "Yönetim");
        Calisan y = new Yazilimci("Ayşe", "Kaya", "Yazılım");
        Calisan s = new SatisTemsilcisi("Ali", "Demir", "Satış");

        h.Gorev();
        y.Gorev(); 
        s.Gorev();  
    }
}
