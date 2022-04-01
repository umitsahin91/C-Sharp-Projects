using System;

namespace sınıf_kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi

            //class SınıfAdı
            //{
            //[Erişim Belirleyici] [Veri Tipi] ÖzellikAdı;
            //[Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdı([Parametre Listesi])
            //{
            //Metot Komutları
            //}
            //}

            //Erişim Belirleyiciler

            //*Public=>Heryerden erişilebilir
            //*Private=>Sadece tanımlandığı sınıftan erişilebilir
            //*Internal=>Bulunduğu proje içerinden erişilebilir
            //*Protected=>Sadece tanımlandığı sınıftan ve o sınıftan kalıtım alan sınıflardan
            //            erişilebilir.

            Calısan calısan1=new Calısan();
            calısan1.Ad="Ayşe";
            calısan1.Soyad="Soyad";
            calısan1.No=23425634;
            calısan1.Departman="İnsan Kaynakları";

            calısan1.CalısanBilgileri();

            Console.WriteLine("**************");

            Calısan calısan2 = new Calısan();
            calısan2.Ad="Deniz";
            calısan2.Soyad="Arda";
            calısan2.No=25646789;
            calısan2.Departman="Satın Alma";

            calısan2.CalısanBilgileri();

            


        }
    }
    class Calısan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalısanBilgileri()
        {
            System.Console.WriteLine("Çalışan Adı : {0}", Ad);
            System.Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
            System.Console.WriteLine("Çalışan Numarası : {0}", No);
            System.Console.WriteLine("Çalışan Departmanı : {0}", Departman);
        }
    }
}
