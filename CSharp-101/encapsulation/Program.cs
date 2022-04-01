using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılamz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sınıf = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SınıfAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.SınıfDusur();
            ogrenci1.SınıfDusur();
            ogrenci1.OgrenciBilgileriniGetir();


        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sınıf;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sınıf
        {
            get => sınıf;
            set
            {
                if (value < 1)
                {
                    System.Console.WriteLine("Sınıf en az 1 olabilir!");
                    sınıf = 1;
                }
                else
                    sınıf = value;
            }
        }

        public Ogrenci() { }
        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sınıf)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sınıf = sınıf;
        }

        public void OgrenciBilgileriniGetir()
        {
            System.Console.WriteLine("***Öğrenci Bilgileri***");
            System.Console.WriteLine("Öğrenci Adı : {0}", this.Isim);
            System.Console.WriteLine("Öğrenci Soyadı : {0}", this.Soyisim);
            System.Console.WriteLine("Öğrenci No : {0}", this.OgrenciNo);
            System.Console.WriteLine("Öğrenci Sınıfı : {0}", this.Sınıf);
        }

        public void SınıfAtlat()
        {
            this.Sınıf = this.Sınıf + 1;
        }
        public void SınıfDusur()
        {
            this.Sınıf = this.Sınıf - 1;
        }




    }

}
