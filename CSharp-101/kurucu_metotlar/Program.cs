using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Çalışan 1***");
            Calısan calısan1 = new Calısan("Ayşe", "Soyad", 23425634, "İnsan Kaynakları");
            // calısan1.Ad="Ayşe";
            // calısan1.Soyad="Soyad";
            // calısan1.No=23425634;
            // calısan1.Departman="İnsan Kaynakları";

            calısan1.CalısanBilgileri();

            Console.WriteLine("***Çalışan 2***");

            Calısan calısan2 = new Calısan();
            calısan2.Ad = "Deniz";
            calısan2.Soyad = "Arda";
            calısan2.No = 25646789;
            calısan2.Departman = "Satın Alma";

            calısan2.CalısanBilgileri();

            Console.WriteLine("***Çalışan 3***");
            Calısan calısan3 = new Calısan("Ayşe", "Soyad");

            calısan3.CalısanBilgileri();
        }
    }
    class Calısan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calısan() { }

        public Calısan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calısan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }


        public void CalısanBilgileri()
        {
            System.Console.WriteLine("Çalışan Adı : {0}", Ad);
            System.Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
            System.Console.WriteLine("Çalışan Numarası : {0}", No);
            System.Console.WriteLine("Çalışan Departmanı : {0}", Departman);
        }
    }
}
