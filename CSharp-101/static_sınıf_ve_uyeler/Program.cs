using System;

namespace static_sınıf_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Çalışan Sayısı : {0}",Calısan.CalisanSayisi);
            Calısan calısan1=new Calısan("Ayşe","Yılmaz","İK");
            System.Console.WriteLine("Çalışan Sayısı : {0}",Calısan.CalisanSayisi);
            Calısan calısan2=new Calısan("Deniz","Arda","İK");
            Calısan calısan3=new Calısan("Zikriye","Ürkmez","İK");
            System.Console.WriteLine("Çalışan Sayısı : {0}",Calısan.CalisanSayisi);

            
            System.Console.WriteLine("Toplama işlemi sonucu : {0}",Islemler.Topla(100,200));
            System.Console.WriteLine("Çıkarma işlemi sonucu : {0}",Islemler.Cıkar(400,50));
            
        }
    }
    class Calısan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calısan()
        {
            calisanSayisi=0;
        }
        public Calısan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }

         public static long Cıkar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
